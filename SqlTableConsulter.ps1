# Cargar MySQL Connector
$connectorPath = "C:\Program Files (x86)\MySQL\Connector NET 8.0\Assemblies\v4.5.2\MySql.Data.dll"
if (-Not (Test-Path $connectorPath)) {
    Write-Error "❌ No se encontró el conector MySQL en la ruta: $connectorPath"
    exit
}
Add-Type -Path $connectorPath

# Solicitar datos al usuario
$server = Read-Host "🔧 Servidor MySQL (ej: localhost)"
$database = Read-Host "📂 Nombre de la base de datos"
$user = Read-Host "👤 Usuario"
$password = Read-Host "🔑 Contraseña"
$tabla = Read-Host "📄 Nombre de la tabla a consultar"

# Construir cadena de conexión
$connectionString = "server=$server;user id=$user;password=$password;database=$database"

# Intentar conexión
try {
    $connection = New-Object MySql.Data.MySqlClient.MySqlConnection $connectionString
    $connection.Open()
    Write-Host "✅ Conexión exitosa con $database en $server." -ForegroundColor Green
} catch {
    Write-Error "❌ Error de conexión: $_"
    exit
}

# Consulta de metadatos
$query = @"
SELECT 
    COLUMN_NAME,
    COLUMN_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT,
    EXTRA,
    COLUMN_KEY
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = '$database' AND TABLE_NAME = '$tabla'
ORDER BY ORDINAL_POSITION;
"@

$command = $connection.CreateCommand()
$command.CommandText = $query
$reader = $command.ExecuteReader()

# Generación del SQL
$sqlCreate = "CREATE TABLE `$tabla` (\n"
$columns = @()
$primaryKeys = @()

while ($reader.Read()) {
    $colName = $reader["COLUMN_NAME"]
    $colType = $reader["COLUMN_TYPE"]
    $isNullable = $reader["IS_NULLABLE"]
    $default = $reader["COLUMN_DEFAULT"]
    $extra = $reader["EXTRA"]
    $key = $reader["COLUMN_KEY"]

    $colDef = "`$colName` $colType"

    if ($isNullable -eq "NO") {
        $colDef += " NOT NULL"
    } else {
        $colDef += " NULL"
    }

    if ($default) {
        if ($default -match "CURRENT_TIMESTAMP|NOW\(\)") {
            $colDef += " DEFAULT $default"
        } else {
            $colDef += " DEFAULT '$default'"
        }
    }

    if ($extra) {
        $colDef += " $extra"
    }

    if ($key -eq "PRI") {
        $primaryKeys += "`$colName`"
    }

    $columns += $colDef
}

$reader.Close()
$connection.Close()

# Añadir columnas al CREATE
$sqlCreate += ($columns -join "`n")

# Añadir clave primaria
if ($primaryKeys.Count -gt 0) {
    $sqlCreate += ",\nPRIMARY KEY (" + ($primaryKeys -join ", ") + ")"
}

$sqlCreate += "\n);"

# Salida
Write-Host "\n--- 🎯 PLANTILLA SQL GENERADA ---\n" -ForegroundColor Cyan
Write-Output $sqlCreate
