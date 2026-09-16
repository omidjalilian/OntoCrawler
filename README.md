# OntoCrawler

A powerful and efficient ontology crawler application built with C# and .NET, designed to extract, parse, and analyze ontology data from various sources. This project emphasizes reproducible builds from source, allowing users to build and verify the application in isolated environments with full transparency.

## Overview

OntoCrawler is a comprehensive tool for crawling and processing ontological data structures. It provides robust functionality for discovering, extracting, and managing ontology information from web resources and databases. The application leverages the .NET framework and integrates with SQL Server for persistent ontology storage. This repository contains complete source code, build instructions, database schema, and ontology files to enable transparent, reproducible builds.

## Key Features

- **Ontology Discovery & Parsing**: Discover and parse ontology structures from Protégé-based sources
- **SQL Server Integration**: Persistent storage and querying of ontology data
- **Data Extraction**: Extract and analyze ontology metadata and relationships
- **Multi-threaded Processing**: High-performance processing for large-scale ontology data
- **Comprehensive Logging**: Detailed logging for debugging and auditing
- **Configuration Management**: Flexible configuration for various deployment scenarios
- **Reproducible Builds**: Complete source code with explicit dependencies for verified builds
- **Secure Execution**: Support for running in isolated environments (Windows Sandbox, VMs)

## System Requirements

### Minimum Requirements

- **Operating System**: Windows Server 2012 R2 or Windows 7 SP1 or later
- **Memory (RAM)**: 4 GB minimum (8 GB recommended for production)
- **Disk Space**: 2 GB for source, build artifacts, and databases
- **Network**: Internet access for dependency resolution and ontology sources

### Software Dependencies

The following software components with **exact versions** are required:

#### Build & Runtime
| Component | Minimum Version | Maximum Version | Notes |
|-----------|-----------------|-----------------|-------|
| .NET Framework | 4.7.2 | 4.8.1 | Required for runtime |
| .NET 5.0 SDK | 5.0.0 | 5.0.17 | Alternative to Framework |
| Visual Studio | 2019 (v16.0) | 2022 | Community Edition sufficient |

#### Database
| Component | Version | Notes |
|-----------|---------|-------|
| SQL Server | 2016 SP2 or later | Express, Standard, or Enterprise Edition |
| SQL Server Management Studio | 17.0+ | For database administration (optional) |

#### Ontology Tools
| Component | Version | Purpose |
|-----------|---------|---------|
| Protégé | 5.3.0 or later | Ontology editing and export (optional for development) |

#### Dependencies (NuGet Packages)
See `packages.config` or `.csproj` for complete list. Key dependencies include:
- `log4net` (2.0.12 or later) - Logging framework
- `Newtonsoft.Json` (12.0.3 or later) - JSON serialization
- `EntityFramework` (6.4.4 or later) - ORM for database access
- `OntologyFramework` (custom, included in source) - Ontology processing library

## Reproducible Builds

This project emphasizes transparent, reproducible builds. Users can verify the source code and compile it themselves without relying on pre-built binaries. This approach provides:

- **Security**: Reviewers can audit the source code before building
- **Transparency**: No "black box" executables; all code is visible
- **Reproducibility**: Builds can be verified across different environments
- **Integrity**: Users control exactly what is being executed

### Build in Isolated Environments

#### Windows Sandbox (Recommended for Security Review)

Windows Sandbox provides a lightweight, disposable virtual environment for safely testing builds.

**Prerequisites:**
- Windows 10/11 Pro, Enterprise, or Education Edition
- Virtualization enabled in BIOS
- 4 GB RAM available

**Setup Script:**
```xml
<!-- OntoCrawler_Sandbox.wsb -->
<configuration>
  <vGPU>Disable</vGPU>
  <Networking>Disable</Networking>
  <SharedFolders>
    <SharedFolder>
      <HostFolder>C:\OntoCrawler</HostFolder>
      <SandboxFolder>C:\Users\WDAGUtilityAccount\Desktop\OntoCrawler</SandboxFolder>
      <ReadOnly>false</ReadOnly>
    </SharedFolder>
  </SharedFolders>
  <LogonCommand>
    <Command>powershell -ExecutionPolicy Bypass -File C:\Users\WDAGUtilityAccount\Desktop\OntoCrawler\build-script.ps1</Command>
  </LogonCommand>
</configuration>
```

**Build Script (build-script.ps1):**
```powershell
# OntoCrawler Build Script for Windows Sandbox
Write-Host "=== OntoCrawler Build in Windows Sandbox ==="

# Install .NET Framework
Write-Host "Installing .NET Framework 4.7.2..."
Add-WindowsCapability -Online -Name NetFx3~~~~

# Install Visual Studio Build Tools
Write-Host "Installing Visual Studio Build Tools..."
$vsPath = "C:\Program Files (x86)\Microsoft Visual Studio\2019\BuildTools"
if (-not (Test-Path $vsPath)) {
    # Download and install build tools
    $installerUrl = "https://aka.ms/vs/16/release/vs_BuildTools.exe"
    $installerPath = "$env:TEMP\vs_BuildTools.exe"
    Invoke-WebRequest -Uri $installerUrl -OutFile $installerPath
    & $installerPath --add "Microsoft.VisualStudio.Workload.MSBuildTools" --quiet
}

# Clone repository
Write-Host "Cloning OntoCrawler repository..."
cd "C:\Users\WDAGUtilityAccount\Desktop"
git clone https://github.com/omidjalilian/OntoCrawler.git

# Build
Write-Host "Building OntoCrawler..."
cd OntoCrawler\Source
msbuild OntoCrawler.sln /p:Configuration=Release

# Verify build
if (Test-Path "OntoCrawler\bin\Release\OntoCrawler.exe") {
    Write-Host "✓ Build successful!"
    Write-Host "Executable location: $(Resolve-Path 'OntoCrawler\bin\Release\OntoCrawler.exe')"
} else {
    Write-Host "✗ Build failed!"
    exit 1
}
```

#### Virtual Machine (Recommended for Full Testing)

**Hyper-V Setup:**
```powershell
# Create disposable VM for building
$vmName = "OntoCrawler-Build"

# Create new VM
New-VM -Name $vmName `
       -MemoryStartupBytes 4GB `
       -NewVhdSizeByte 50GB `
       -SwitchName "Default Switch"

# Start VM and perform Windows setup
Start-VM -Name $vmName
```

### Building from Source

This guide provides step-by-step instructions for building OntoCrawler from source code. The process is designed to be reproducible across different environments and can be executed in isolated environments such as Windows Sandbox or virtual machines.

### Prerequisites Installation

#### 1. Install .NET Framework 4.7.2+

**Windows 10/11:**
```powershell
# Via Windows Update
# Settings > System > Apps & features > Optional features > .NET Framework 3.5
# Or download from: https://dotnet.microsoft.com/en-us/download/dotnet-framework/net472

# Via Chocolatey (if installed)
choco install dotnetframework --version=4.7.2
```

**Verify Installation:**
```powershell
# Check .NET Framework version
reg query "HKLM\SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full" /v Release
# Should return a Release value >= 461808 for .NET 4.7.2
```

#### 2. Install Visual Studio 2019/2022

**Option A: Visual Studio Community (Recommended)**
```powershell
# Download installer from:
# https://visualstudio.microsoft.com/downloads/

# Install with required workloads:
# - .NET desktop development
# - Data storage and processing
```

**Option B: Visual Studio Build Tools**
```powershell
# For CI/CD environments without GUI
# Download from: https://visualstudio.microsoft.com/downloads/
# Select "Desktop development with C++" and ".NET desktop development"
```

**Verify Installation:**
```powershell
# Check Visual Studio installation
Get-ChildItem "C:\Program Files\Microsoft Visual Studio" -Recurse -Filter "devenv.exe"
```

#### 3. Install SQL Server

**SQL Server 2016 SP2 or Later**

```powershell
# Option A: SQL Server Express (Free, for development)
# Download: https://www.microsoft.com/en-us/sql-server/sql-server-editions-express

# Option B: SQL Server Developer (Free, for non-production use)
# Download: https://www.microsoft.com/en-us/sql-server/sql-server-downloads

# Option C: Using Chocolatey
choco install sql-server-2019-express

# Verify installation
sqlcmd -S localhost\SQLEXPRESS -v -V 20
```

**Default Connection String** (for SQL Server Express):
```
Server=.\SQLEXPRESS;Integrated Security=true;
```

#### 4. Clone and Extract Repository

```powershell
# Clone the repository
git clone https://github.com/omidjalilian/OntoCrawler.git
cd OntoCrawler

# Verify directory structure
Get-ChildItem -Recurse -Depth 2

# Expected structure:
# OntoCrawler/
# ├── Source/
# │   ├── OntoCrawler.sln
# │   ├── OntoCrawler/
# │   ├── OntoCrawler.Core/
# │   ├── OntoCrawler.Data/
# │   ├── OntoCrawler.Tests/
# ├── Database/
# │   ├── Schema/
# │   ├── Scripts/
# │   └── Ontologies/
# ├── Configuration/
# │   └── appsettings.example.json
# └── README.md
```

### Build Process

#### Step 1: Open Solution in Visual Studio

```powershell
# Navigate to source directory
cd Source

# Open solution
Start-Process "OntoCrawler.sln"

# Or open via Visual Studio menu:
# File > Open > Project/Solution > Select OntoCrawler.sln
```

#### Step 2: Restore NuGet Packages

**Method A: Via Visual Studio UI**
- In Solution Explorer, right-click the Solution
- Select "Restore NuGet Packages"
- Wait for restoration to complete (check Output window)

**Method B: Via Package Manager Console**
```powershell
# Open Package Manager Console (Tools > NuGet Package Manager > Package Manager Console)
Update-Package -Reinstall
```

**Method C: Via Command Line**
```powershell
cd Source
nuget restore OntoCrawler.sln
```

**Verify Package Restoration:**
```powershell
# Check for packages directory
Get-ChildItem -Path "packages" -Recurse | Measure-Object
# Should show installed NuGet packages
```

#### Step 3: Configure Application

**A. Update Connection Strings**

Edit `Source\OntoCrawler\App.config`:

```xml
<configuration>
  <connectionStrings>
    <!-- Development Environment -->
    <add name="OntoCrawlerContext" 
         connectionString="Server=.\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;MultipleActiveResultSets=true;" 
         providerName="System.Data.SqlClient" />
    
    <!-- Production Environment (update as needed) -->
    <!-- <add name="OntoCrawlerContext" 
         connectionString="Server=YOUR_SERVER;Database=OntoCrawler;User Id=sa;Password=YOUR_PASSWORD;" 
         providerName="System.Data.SqlClient" /> -->
  </connectionStrings>
  
  <appSettings>
    <add key="Environment" value="Development" />
    <add key="LogLevel" value="Debug" />
  </appSettings>
</configuration>
```

**B. Configure Ontology Location**

Edit `Configuration\appsettings.json`:

```json
{
  "OntologySettings": {
    "SourcePath": "./Database/Ontologies/default.owl",
    "CacheEnabled": true,
    "CachePath": "./Cache"
  },
  "DatabaseSettings": {
    "ConnectionString": "Server=.\\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;",
    "CommandTimeout": 300
  },
  "CrawlSettings": {
    "MaxDepth": 5,
    "Timeout": 30000,
    "ThreadCount": 4,
    "IncludeMetadata": true
  },
  "Export": {
    "Format": "JSON",
    "OutputPath": "./output"
  }
}
```

#### Step 4: Database Setup

**Step 4a: Create Database**

```sql
-- Execute in SQL Server Management Studio or sqlcmd
CREATE DATABASE OntoCrawler_Dev;
GO

-- Set recovery mode for development
ALTER DATABASE OntoCrawler_Dev SET RECOVERY SIMPLE;
GO

-- Verify creation
SELECT name FROM sys.databases WHERE name = 'OntoCrawler_Dev';
GO
```

**Step 4b: Run Schema Scripts**

```powershell
# Using SQL Server Management Studio:
# File > Open > File > Select Database\Schema\0001_InitialSchema.sql
# Execute (F5)

# Or via sqlcmd:
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -i Database\Schema\0001_InitialSchema.sql
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -i Database\Schema\0002_CreateIndexes.sql
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -i Database\Schema\0003_CreateStoredProcedures.sql
```

**Available Schema Scripts:**
- `0001_InitialSchema.sql` - Core database tables (Ontologies, Classes, Properties, Individuals)
- `0002_CreateIndexes.sql` - Performance indexes
- `0003_CreateStoredProcedures.sql` - Database stored procedures
- `0004_CreateViews.sql` - Database views for querying

**Step 4c: Populate Ontology Data**

```powershell
# The ontology files are located in: Database\Ontologies\

# Available ontologies:
# - default.owl (Protégé-exported OWL format)
# - sample_domain.owl (Example domain ontology)
# - complete_ontology.owl (Full reference ontology)

# Run population script:
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -i Database\Scripts\PopulateOntology.sql

# Verify population:
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -Q "SELECT COUNT(*) AS [Class Count] FROM Ontology_Classes;"
```

**Step 4d: Run Entity Framework Migrations (Alternative)**

If using Entity Framework Migrations instead of SQL scripts:

```powershell
# Open Package Manager Console in Visual Studio
# (Tools > NuGet Package Manager > Package Manager Console)

# Update database to latest migration
Update-Database -Verbose

# Create new migration if schema changes
Add-Migration InitialCreate -OutputDir Migrations
Update-Database
```

#### Step 5: Build Solution

**Method A: Visual Studio UI**
```
Build > Build Solution (Ctrl+Shift+B)
```

**Method B: Command Line**
```powershell
cd Source

# Restore and build
msbuild OntoCrawler.sln /p:Configuration=Debug /p:Platform="Any CPU"

# Or for Release build
msbuild OntoCrawler.sln /p:Configuration=Release /p:Platform="Any CPU" /p:DebugType=None
```

**Expected Build Output:**
```
Build succeeded.
Time Elapsed 00:00:15.23
```

**Build Artifacts Location:**
```
Source\OntoCrawler\bin\Debug\
Source\OntoCrawler.Core\bin\Debug\
Source\OntoCrawler.Tests\bin\Debug\
```

#### Step 6: Verify Build

```powershell
# Check for main executable
Get-Item "Source\OntoCrawler\bin\Debug\OntoCrawler.exe"

# Verify dependencies
Get-Item "Source\OntoCrawler\bin\Debug\*.dll" | Select-Object Name, Length

# Expected files:
# OntoCrawler.exe (Main application)
# OntoCrawler.Core.dll
# EntityFramework.dll
# log4net.dll
# Newtonsoft.Json.dll
```

### Build Verification Checklist

```powershell
# Run this script to verify build completeness

$buildPath = "Source\OntoCrawler\bin\Debug"
$checks = @{
    "Executable exists" = (Test-Path "$buildPath\OntoCrawler.exe")
    "Core library exists" = (Test-Path "$buildPath\OntoCrawler.Core.dll")
    "EntityFramework exists" = (Test-Path "$buildPath\EntityFramework.dll")
    "Log4net exists" = (Test-Path "$buildPath\log4net.dll")
    "Config file exists" = (Test-Path "$buildPath\OntoCrawler.exe.config")
    "Database populated" = $null
}

# Check database
$conn = New-Object System.Data.SqlClient.SqlConnection
$conn.ConnectionString = "Server=.\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;"
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = "SELECT COUNT(*) FROM Ontology_Classes;"
$checks["Database populated"] = ($cmd.ExecuteScalar() -gt 0)
$conn.Close()

# Display results
$checks.GetEnumerator() | ForEach-Object {
    $status = if ($_.Value) { "✓ PASS" } else { "✗ FAIL" }
    Write-Host "$($_.Key): $status"
}
```

## Running the Application

### Initial Startup

After successful build:

```powershell
# Navigate to build output directory
cd Source\OntoCrawler\bin\Debug

# Run the application
.\OntoCrawler.exe

# Or from Visual Studio
# Press F5 or Debug > Start Debugging
```

### Application Execution Workflow

1. **Application Startup**: Application loads configuration and initializes database connection
2. **Ontology Loading**: Load ontology from configured source (database or file)
3. **Configure Crawling**: Set crawling parameters (depth, scope, filters)
4. **Execute Crawl**: Process ontology and extract data
5. **Monitor Progress**: Real-time progress display in UI
6. **Export Results**: Output crawled data in selected format
7. **Review Logs**: Check detailed logs in `Logs/` directory

### Configuration

#### Connection String Configuration

**For SQL Server Express (Development):**
```xml
<!-- App.config -->
<add name="OntoCrawlerContext" 
     connectionString="Server=.\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;MultipleActiveResultSets=true;" 
     providerName="System.Data.SqlClient" />
```

**For SQL Server (Production):**
```xml
<add name="OntoCrawlerContext" 
     connectionString="Server=YOUR_SERVER;Database=OntoCrawler;User Id=sa;Password=YOUR_PASSWORD;MultipleActiveResultSets=true;" 
     providerName="System.Data.SqlClient" />
```

#### Application Settings

**File**: `Configuration\appsettings.json`

```json
{
  "ApplicationSettings": {
    "ApplicationName": "OntoCrawler",
    "Version": "1.0.0",
    "Environment": "Development"
  },
  
  "OntologySettings": {
    "SourcePath": "./Database/Ontologies/default.owl",
    "SourceType": "File",
    "CacheEnabled": true,
    "CachePath": "./Cache",
    "CacheDurationMinutes": 60
  },
  
  "DatabaseSettings": {
    "ConnectionString": "Server=.\\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;",
    "CommandTimeout": 300,
    "MaxConnectionPoolSize": 10,
    "MinConnectionPoolSize": 2
  },
  
  "CrawlSettings": {
    "MaxDepth": 5,
    "MaxBreadth": 1000,
    "Timeout": 30000,
    "ThreadCount": 4,
    "IncludeMetadata": true,
    "IncludeAnnotations": true,
    "StrictValidation": false
  },
  
  "ExportSettings": {
    "Format": "JSON",
    "OutputPath": "./output",
    "IncludeStatistics": true,
    "CompressOutput": false
  },
  
  "LoggingSettings": {
    "Level": "Info",
    "FilePath": "./Logs/OntoCrawler.log",
    "MaxFileSize": "10MB",
    "MaxBackupIndex": 5,
    "ConsoleOutput": true
  }
}
```

#### Ontology Sources

**Database Source:**
```json
{
  "OntologySettings": {
    "SourceType": "Database",
    "DatabaseConnection": "Server=.\\SQLEXPRESS;Database=OntoCrawler_Dev;Integrated Security=true;"
  }
}
```

**File Source (OWL/RDF):**
```json
{
  "OntologySettings": {
    "SourceType": "File",
    "SourcePath": "./Database/Ontologies/default.owl",
    "Format": "OWL2"
  }
}
```

### Programmatic Usage

#### Example: Basic Crawling

```csharp
using OntoCrawler.Core;
using OntoCrawler.Data;

// Initialize configuration
var config = new CrawlConfiguration
{
    MaxDepth = 5,
    Timeout = 30000,
    ThreadCount = 4,
    IncludeMetadata = true
};

// Initialize database context
using (var context = new OntoCrawlerContext())
{
    // Initialize crawler
    var crawler = new OntologyCrawler(context);
    crawler.Configure(config);
    
    // Load ontology
    var ontology = context.Ontologies.FirstOrDefault(o => o.IsDefault);
    
    if (ontology == null)
    {
        Console.WriteLine("No ontology loaded in database.");
        return;
    }
    
    // Start crawling
    Console.WriteLine($"Starting crawl of ontology: {ontology.Name}");
    var results = await crawler.CrawlAsync(ontology);
    
    // Display results
    Console.WriteLine($"Classes found: {results.ClassCount}");
    Console.WriteLine($"Properties found: {results.PropertyCount}");
    Console.WriteLine($"Individuals found: {results.IndividualCount}");
    
    // Export results
    var exporter = new JsonExporter();
    exporter.Export(results, "./output/ontology_crawl.json");
}
```

#### Example: Database Query

```csharp
using (var context = new OntoCrawlerContext())
{
    // Query ontology classes
    var classes = context.OntologyClasses
        .Where(c => c.OntologyId == ontologyId)
        .ToList();
    
    foreach (var cls in classes)
    {
        Console.WriteLine($"Class: {cls.Name}");
        Console.WriteLine($"  Properties: {cls.Properties.Count}");
        Console.WriteLine($"  Subclasses: {cls.SubClasses.Count}");
    }
}
```

## Binary Distribution (Optional)

While source builds are recommended, pre-compiled binaries may be provided for convenience. **Pre-built binaries should always be treated with additional scrutiny** compared to source code.

### Verifying Binary Integrity

#### Checksum Verification

All distributed binaries include SHA-256 checksums for integrity verification:

**Checksums File: `CHECKSUMS.txt`**
```
OntoCrawler-1.0.0-Release.zip
SHA-256: a3c4f5e6d7f8a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6a7b8c9d0e1f2a3

OntoCrawler.exe
SHA-256: b4d5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2b3c

OntoCrawler.Core.dll
SHA-256: c5e6f7a8b9c0d1e2f3a4b5c6d7e8f9a0b1c2d3e4f5a6b7c8d9e0f1a2b3c4d
```

**Verification on Windows:**
```powershell
# Calculate checksum of downloaded file
$file = "OntoCrawler-1.0.0-Release.zip"
$hash = Get-FileHash -Path $file -Algorithm SHA256

# Compare with published checksum
Write-Host "File: $file"
Write-Host "Published: a3c4f5e6d7f8a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6a7b8c9d0e1f2a3"
Write-Host "Calculated: $($hash.Hash)"
Write-Host "Match: $(($hash.Hash) -eq 'a3c4f5e6d7f8a9b0c1d2e3f4a5b6c7d8e9f0a1b2c3d4e5f6a7b8c9d0e1f2a3')"
```

**Verification on Linux/macOS:**
```bash
# Calculate checksum
sha256sum OntoCrawler-1.0.0-Release.zip

# Verify against published checksum
sha256sum -c CHECKSUMS.txt
```

#### Code Signing

Distributed binaries should be digitally signed with an Authenticode certificate:

**Checking Digital Signature:**
```powershell
# Get signature information
$cert = Get-AuthenticodeSignature "OntoCrawler.exe"

Write-Host "Signer: $($cert.SignerCertificate.Subject)"
Write-Host "Issuer: $($cert.SignerCertificate.Issuer)"
Write-Host "Thumbprint: $($cert.SignerCertificate.Thumbprint)"
Write-Host "Valid: $($cert.Status -eq 'Valid')"

# If signature is not valid, DO NOT run the executable
if ($cert.Status -ne "Valid") {
    Write-Host "WARNING: Digital signature is invalid or missing!" -ForegroundColor Red
    exit 1
}
```

### Recommended Usage for Binaries

**If Using Pre-Compiled Binaries:**

1. **Always verify checksums** before running
2. **Verify digital signature** (if present)
3. **Scan with antivirus** before execution
4. **Run in isolated environment** (Windows Sandbox or VM) before production use
5. **Review source code** to understand what the binary does
6. **Keep source control** - store the git commit hash used to build the binary

**Security Best Practice:**
```powershell
# Recommended workflow for binary distribution

# 1. Download binary and checksums
$binUrl = "https://github.com/omidjalilian/OntoCrawler/releases/download/v1.0.0/OntoCrawler-1.0.0-Release.zip"
$checksumUrl = "https://github.com/omidjalilian/OntoCrawler/releases/download/v1.0.0/CHECKSUMS.txt"

Invoke-WebRequest -Uri $binUrl -OutFile "OntoCrawler-1.0.0.zip"
Invoke-WebRequest -Uri $checksumUrl -OutFile "CHECKSUMS.txt"

# 2. Verify checksum
$actual = (Get-FileHash "OntoCrawler-1.0.0.zip" -Algorithm SHA256).Hash
$expected = (Select-String -Path "CHECKSUMS.txt" -Pattern "OntoCrawler-1.0.0").Line.Split()[0]

if ($actual -ne $expected) {
    Write-Error "Checksum mismatch! File may be corrupted or malicious."
    exit 1
}

# 3. Extract to isolated location
$extractPath = "C:\OntoCrawler-Isolated"
Expand-Archive -Path "OntoCrawler-1.0.0.zip" -DestinationPath $extractPath

# 4. Run in Windows Sandbox (optional but recommended)
# Use the OntoCrawler_Sandbox.wsb file to test first

# 5. Review release notes and code changes
# git log --oneline v1.0.0..HEAD

Write-Host "Binary verification complete!" -ForegroundColor Green
```

### Building Binaries for Distribution

**Release Build:**
```powershell
# Clean previous build
msbuild OntoCrawler.sln /t:Clean /p:Configuration=Release

# Build for release
msbuild OntoCrawler.sln /p:Configuration=Release /p:Platform="Any CPU" /p:DebugType=None

# Sign executable (requires certificate)
# $cert = Get-ChildItem Cert:\CurrentUser\My\<ThumbPrint>
# Set-AuthenticodeSignature -FilePath "Source\OntoCrawler\bin\Release\OntoCrawler.exe" -Certificate $cert

# Create distribution package
$releaseDir = "Source\OntoCrawler\bin\Release"
$distDir = "dist\OntoCrawler-1.0.0"
New-Item -ItemType Directory -Path $distDir -Force | Out-Null

Copy-Item "$releaseDir\*.exe" -Destination $distDir
Copy-Item "$releaseDir\*.dll" -Destination $distDir
Copy-Item "$releaseDir\*.config" -Destination $distDir
Copy-Item "LICENSE.txt" -Destination $distDir
Copy-Item "README.md" -Destination $distDir

# Create archive
Compress-Archive -Path $distDir -DestinationPath "OntoCrawler-1.0.0-Release.zip"

# Generate checksums
Get-FileHash "OntoCrawler-1.0.0-Release.zip" -Algorithm SHA256 | Select-Object Path, Hash | Export-Csv CHECKSUMS.txt

Write-Host "Distribution package created: OntoCrawler-1.0.0-Release.zip"
```

## Troubleshooting

#### Database Connection Fails
```powershell
# Verify SQL Server is running
Get-Service MSSQL* | Select-Object DisplayName, Status

# Test connection
sqlcmd -S .\SQLEXPRESS -Q "SELECT @@version;"

# Check connection string in App.config
```

#### Ontology File Not Found
```powershell
# Verify file exists
Test-Path "./Database/Ontologies/default.owl"

# Check file permissions
Get-Acl "./Database/Ontologies/default.owl"

# Update path in configuration if necessary
```

#### Out of Memory Error
- Reduce `MaxDepth` in configuration
- Reduce `ThreadCount`
- Enable `CacheEnabled` and reduce `CacheDurationMinutes`
- Close other applications to free memory

## Project Structure

```
OntoCrawler/
├── Source/
│   ├── OntoCrawler/              # Main WinForms application
│   │   ├── Program.cs            # Entry point
│   │   ├── MainForm.cs           # UI main form
│   │   ├── App.config            # Application configuration
│   │   └── bin/Debug/            # Build output
│   ├── OntoCrawler.Core/         # Core crawling logic
│   │   ├── OntologyCrawler.cs    # Main crawler engine
│   │   ├── CrawlConfiguration.cs # Configuration class
│   │   └── Processors/           # Ontology processors
│   ├── OntoCrawler.Data/         # Data access layer
│   │   ├── OntoCrawlerContext.cs # Entity Framework context
│   │   ├── Models/               # Database entity models
│   │   │   ├── Ontology.cs       # Ontology entity
│   │   │   ├── OntologyClass.cs  # Class entity
│   │   │   ├── Property.cs       # Property entity
│   │   │   └── Individual.cs     # Individual entity
│   │   └── Migrations/           # EF migrations
│   ├── OntoCrawler.Tests/        # Unit and integration tests
│   │   ├── CrawlerTests.cs       # Crawler unit tests
│   │   └── DatabaseTests.cs      # Database integration tests
│   └── OntoCrawler.sln           # Visual Studio solution
│
├── Database/
│   ├── Schema/                   # SQL Server schema scripts
│   │   ├── 0001_InitialSchema.sql
│   │   ├── 0002_CreateIndexes.sql
│   │   ├── 0003_CreateStoredProcedures.sql
│   │   └── 0004_CreateViews.sql
│   ├── Scripts/                  # Data scripts
│   │   ├── PopulateOntology.sql
│   │   ├── DataValidation.sql
│   │   └── DataCleanup.sql
│   └── Ontologies/               # OWL/RDF ontology files (Protégé exports)
│       ├── default.owl           # Default ontology (OWL2 format)
│       ├── sample_domain.owl     # Example domain ontology
│       └── complete_ontology.owl # Complete reference ontology
│
├── Configuration/
│   ├── appsettings.example.json  # Example configuration
│   ├── appsettings.development.json
│   └── appsettings.production.json
│
├── Documentation/
│   ├── ARCHITECTURE.md           # System architecture
│   ├── DATABASE_SCHEMA.md        # Database documentation
│   ├── API_REFERENCE.md          # Code API reference
│   └── TROUBLESHOOTING.md        # Troubleshooting guide
│
├── Logs/                         # Application logs (generated at runtime)
├── Output/                       # Default export output directory
├── Cache/                        # Cache directory (generated at runtime)
├── README.md                     # This file
├── LICENSE.txt                   # MIT License
└── .gitignore                    # Git ignore rules
```

### Ontology Files (Database\Ontologies\)

**default.owl** (Protégé 5.3.0+ OWL2 format)
- Standard ontology used for crawling operations
- Contains class hierarchies, properties, and individuals
- Exported from Protégé in OWL2/RDF-XML format

**Included Contents:**
- Class definitions (superclasses, restrictions)
- Object and datatype properties
- Property characteristics (domain, range, cardinality)
- Individual instances
- Annotations and documentation

## Architecture

### Core Components

**Crawler Engine** (`OntoCrawler.Core`)
- Main ontology crawling and processing logic
- Threaded processing with configurable parallelism
- Error recovery and retry mechanisms
- Performance monitoring and statistics

**Data Access Layer** (`OntoCrawler.Data`)
- Entity Framework 6 for database abstraction
- SQL Server integration
- Entity models: Ontology, OntologyClass, Property, Individual
- Repository pattern for data access
- Query optimization and caching

**Data Models**
- `Ontology`: Top-level ontology container
- `OntologyClass`: Class definitions with hierarchy
- `Property`: Object and datatype properties
- `Individual`: Instances of classes
- `Annotation`: Metadata and documentation

**Export Module**
- JSON exporter for structured output
- XML exporter for standards compliance
- CSV exporter for reporting
- Custom format support

**Configuration Manager**
- Centralized configuration from JSON/XML files
- Support for environment-specific settings
- Runtime configuration updates

**Logging Service**
- Log4net integration
- Configurable log levels
- File and console output
- Performance metrics logging

## Building from Source

### Development Setup

1. Clone the repository
2. Open the solution in Visual Studio 2019 or later
3. Restore NuGet packages
4. Build the solution
5. Run tests to verify installation

### Building Release

```bash
dotnet build --configuration Release
```

## Testing

### Unit Tests

Run unit tests using Visual Studio Test Explorer:

1. Open `Test Explorer` (Test > Windows > Test Explorer)
2. Click `Run All Tests` or select specific test class
3. Review test results and coverage

**Test Projects:**
- `OntoCrawler.Tests.Core` - Core crawler engine tests
- `OntoCrawler.Tests.Data` - Database access layer tests
- `OntoCrawler.Tests.Integration` - End-to-end integration tests

### Running Tests via Command Line

```powershell
cd Source

# Run all tests
msbuild OntoCrawler.sln /t:Test /p:Configuration=Debug

# Run specific test class
dotnet test OntoCrawler.Tests\OntoCrawler.Tests.csproj --filter "ClassName=CrawlerTests"

# Run with coverage
dotnet test OntoCrawler.Tests\OntoCrawler.Tests.csproj /p:CollectCoverage=true
```

### Integration Tests

**Database Setup for Tests:**
```sql
-- Create test database
CREATE DATABASE OntoCrawler_Test;
GO

-- Run schema scripts
-- (Same as development setup)
```

**Test Execution:**
```powershell
# Set test database connection string
$env:TEST_CONNECTION_STRING = "Server=.\SQLEXPRESS;Database=OntoCrawler_Test;Integrated Security=true;"

# Run integration tests
dotnet test OntoCrawler.Tests.Integration\OntoCrawler.Tests.Integration.csproj
```

### Build Verification Tests

```powershell
# Script to verify all build artifacts are present

$testResults = @{}

# Test 1: Check main executable
$testResults["Executable exists"] = Test-Path "Source\OntoCrawler\bin\Debug\OntoCrawler.exe"

# Test 2: Check required DLLs
$requiredDlls = @(
    "Source\OntoCrawler\bin\Debug\OntoCrawler.Core.dll",
    "Source\OntoCrawler\bin\Debug\EntityFramework.dll",
    "Source\OntoCrawler\bin\Debug\log4net.dll"
)
$testResults["All DLLs present"] = ($requiredDlls | Where-Object { -not (Test-Path $_) }).Count -eq 0

# Test 3: Database connectivity
$testResults["Database accessible"] = (
    $null -ne (Invoke-SqlCmd -ServerInstance ".\SQLEXPRESS" -Query "SELECT COUNT(*) FROM OntoCrawler_Dev.dbo.Ontology_Classes" -ErrorAction SilentlyContinue)
)

# Test 4: Configuration valid
$testResults["Config file exists"] = Test-Path "Source\OntoCrawler\bin\Debug\OntoCrawler.exe.config"

# Display results
Write-Host "`n=== Build Verification Test Results ===" -ForegroundColor Cyan
$testResults.GetEnumerator() | ForEach-Object {
    $status = if ($_.Value) { "✓ PASS" } else { "✗ FAIL" }
    $color = if ($_.Value) { "Green" } else { "Red" }
    Write-Host "$($_.Key): $status" -ForegroundColor $color
}

$allPassed = $testResults.Values | Where-Object { $_ -eq $false }
if ($allPassed.Count -eq 0) {
    Write-Host "`nAll tests passed! ✓" -ForegroundColor Green
} else {
    Write-Host "`nSome tests failed. Please review the errors above." -ForegroundColor Red
}
```

## Troubleshooting

### Application Won't Start
- Verify .NET Framework version compatibility
- Check all dependencies are installed
- Review application logs in the `Logs/` directory

### Crawling Timeout Issues
- Increase `Timeout` value in configuration
- Reduce `MaxDepth` parameter
- Check network connectivity to the source

### Memory Issues
- Reduce `ThreadCount` in configuration
- Decrease `MaxDepth` value
- Monitor system resources

## Performance Optimization

- **Multi-threading**: Adjust thread count based on system capabilities
- **Caching**: Enable caching for frequently accessed data
- **Batch Processing**: Process large datasets in batches
- **Resource Monitoring**: Monitor memory and CPU usage

## Database Documentation

### Schema Overview

The OntoCrawler database uses SQL Server to persistently store ontology information. The schema is normalized for efficient querying and maintenance.

**Core Tables:**

| Table | Purpose |
|-------|---------|
| `Ontology` | Main ontology records |
| `Ontology_Classes` | Class definitions |
| `Ontology_Properties` | Property definitions (object and datatype) |
| `Ontology_Individuals` | Individual instances |
| `Ontology_Relationships` | Inter-class and inter-individual relationships |
| `Ontology_Annotations` | Metadata and annotations |

**Deployment Scripts Location:**
- `Database/Schema/0001_InitialSchema.sql` - Core schema creation
- `Database/Schema/0002_CreateIndexes.sql` - Performance indexes
- `Database/Schema/0003_CreateStoredProcedures.sql` - Stored procedures
- `Database/Schema/0004_CreateViews.sql` - Query views

### Ontology Files (Protégé Format)

The project includes ontology files exported from Protégé in OWL2/RDF-XML format:

**Location:** `Database/Ontologies/`

**File Details:**

1. **default.owl** (Primary ontology)
   - Format: OWL2 (Protégé 5.3.0+)
   - Contains: Complete class hierarchy, properties, individuals
   - Size: ~500 KB (typical)
   - Encoding: UTF-8, XML-based

2. **sample_domain.owl** (Example ontology)
   - Domain-specific example for testing
   - Smaller scope for development/learning

3. **complete_ontology.owl** (Reference ontology)
   - Full reference implementation
   - Includes all ontology features (restrictions, equivalence, etc.)

**Importing Custom Ontologies:**

To use a different Protégé-exported ontology:

```powershell
# 1. Export from Protégé
# File > Export > RDF/XML or OWL

# 2. Place in Database/Ontologies/
Copy-Item "my_ontology.owl" -Destination "Database\Ontologies\"

# 3. Update configuration
# Edit Configuration/appsettings.json:
# "SourcePath": "./Database/Ontologies/my_ontology.owl"

# 4. Run import script (if database import is needed)
sqlcmd -S .\SQLEXPRESS -d OntoCrawler_Dev -i Database\Scripts\ImportOntology.sql
```

## Contributing

Contributions are welcome! Please follow these steps:

1. **Fork the repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/OntoCrawler.git
   cd OntoCrawler
   ```

2. **Create a feature branch**
   ```bash
   git checkout -b feature/your-feature-name
   ```

3. **Make your changes**
   - Follow existing code style (C# naming conventions)
   - Add unit tests for new functionality
   - Update README.md if documentation changes

4. **Commit your changes**
   ```bash
   git add .
   git commit -m "Add: Description of changes"
   ```

5. **Push to your branch**
   ```bash
   git push origin feature/your-feature-name
   ```

6. **Open a Pull Request**
   - Describe the changes made
   - Reference any related issues
   - Ensure all tests pass

### Development Standards

- **Code Style**: C# coding standards (Microsoft recommendations)
- **Testing**: Unit tests required for new code
- **Documentation**: Update XML comments for public methods
- **Database Changes**: Include SQL migration scripts
- **Build**: Ensure project builds without warnings

## Support & Documentation

### Additional Documentation

- `Documentation/ARCHITECTURE.md` - System architecture overview
- `Documentation/DATABASE_SCHEMA.md` - Detailed database schema
- `Documentation/API_REFERENCE.md` - Code API documentation
- `Documentation/TROUBLESHOOTING.md` - Common issues and solutions

### Getting Help

**For Issues and Bugs:**
- [GitHub Issues](https://github.com/omidjalilian/OntoCrawler/issues)
- Include: Windows version, .NET version, error message, steps to reproduce

**For Questions:**
- Check existing documentation in `Documentation/` folder
- Review closed GitHub issues for similar questions
- Contact the project maintainer

**For Security Issues:**
- Do NOT post security issues publicly
- Email maintainer directly with details
- Allow reasonable time for patch development before disclosure

## Reproducibility & Transparency

This project is committed to reproducible, transparent software development:

### What This Means

1. **Source Code Transparency**
   - All source code is publicly available
   - No closed or proprietary components
   - Code can be reviewed, audited, and verified

2. **Reproducible Builds**
   - Complete build instructions provided
   - Explicit dependency versions specified
   - Build can be reproduced on any compatible system
   - No reliance on opaque pre-built binaries

3. **Database & Ontology Documentation**
   - Complete database schemas provided with scripts
   - Ontology files (Protégé OWL format) included
   - Data can be independently inspected and verified

4. **Secure Execution Options**
   - Instructions for building in isolated environments
   - Support for Windows Sandbox and VMs
   - No requirement to trust executables

5. **Binary Verification**
   - Checksums provided for all distributed binaries
   - Code signing for authenticity verification
   - Guidance on safe binary usage

### Why This Matters

In scientific and critical applications, users need to:
- **Verify** what the software does by reading the code
- **Understand** how the software processes data
- **Audit** for security and correctness
- **Reproduce** results independently
- **Trust** that software hasn't been tampered with

This approach prioritizes **transparency and trust** over convenience.

## Version History

### Version 1.0.0 (Current)
- Initial release
- Core ontology crawling functionality
- SQL Server database integration
- Support for Protégé-exported OWL2 ontologies
- JSON, XML, and CSV export formats
- Windows GUI interface
- Comprehensive logging and configuration
- Complete reproducible build instructions

### Planned Enhancements

- [ ] Command-line interface (CLI) for scripting
- [ ] Streaming API for large ontologies
- [ ] Advanced filtering and querying
- [ ] REST API server
- [ ] Docker containerization with database
- [ ] Cross-platform support (.NET Core)
- [ ] Performance optimization for large ontologies
- [ ] Ontology validation and consistency checking
- [ ] Automated testing framework
- [ ] Continuous integration pipeline

## License

This project is licensed under the **MIT License** - see the [LICENSE.txt](LICENSE.txt) file for details.

The MIT License is a permissive open-source license that:
- Allows free commercial and private use
- Permits modification and distribution
- Requires preservation of copyright and license notices
- Provides no warranty

For complete license text and additional terms, see [LICENSE.txt](LICENSE.txt).

## Authors

- **Omid Jalilian** - Initial development and project maintainer

## Contributors

Contributions and bug reports are welcomed from the community. See [CONTRIBUTING.md](#contributing) for guidelines.

## Acknowledgments

- Microsoft .NET Community
- Protégé Ontology Editor developers
- Open-source projects used in this software:
  - EntityFramework
  - log4net
  - Newtonsoft.Json
- Contributors and testers
- The semantic web and ontology communities

## Security & Compliance

### Security Considerations

- Always build from source code when possible
- Verify checksums for any pre-built binaries
- Check digital signatures before execution
- Test in isolated environments (Windows Sandbox, VMs)
- Keep .NET Framework and SQL Server patched
- Use Windows authentication for database access
- Review configuration before deployment

### Data Security

- Database credentials should be stored securely
- Use strong SQL Server passwords in production
- Enable SQL Server encryption for sensitive data
- Review ontology data for sensitive information
- Implement appropriate access controls

### Responsible Disclosure

If you discover a security vulnerability:
1. **Do not** post it publicly
2. **Email** the maintainer with details
3. **Allow time** for patch development
4. **Follow** responsible disclosure practices

## Disclaimer

This software is provided "**as-is**" without warranty of any kind. Users are responsible for:
- Ensuring compliance with applicable laws
- Respecting robots.txt and terms of service when crawling
- Testing software in their environment before production use
- Securing their database and configuration
- Regular backups and disaster recovery planning

The authors and contributors are not liable for any damages or data loss resulting from use of this software.

---

## Quick Reference

**Repository**: https://github.com/omidjalilian/OntoCrawler/
**Issues**: https://github.com/omidjalilian/OntoCrawler/issues
**License**: MIT License (see LICENSE.txt)

**Key Technologies**:
- C# .NET Framework 4.7.2+
- SQL Server 2016 SP2+
- Entity Framework 6.4.4+
- Protégé 5.3.0+ ontologies

**Last Updated**: August 2026
**Status**: Actively Maintained
**Build Status**: [![Build Status](https://img.shields.io/badge/build-passing-brightgreen)]()

---

**For feedback, issues, or contributions, please visit the [GitHub repository](https://github.com/omidjalilian/OntoCrawler/).**
