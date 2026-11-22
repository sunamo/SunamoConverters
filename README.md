# SunamoConverters

## Short description

Převodníky mezi mnoha formáty a datovými typy v .NET.


Converters between many formats and data types

## Overview

SunamoConverters is part of the Sunamo package ecosystem, providing modular, platform-independent utilities for .NET development.

## Main Components

### Key Classes

- **BlobConverter**
- **MultilineAsOneLine**
- **PluralConverter**
- **PropertyTypesConverter**
- **BigEndianBitConverter**
- **ConvertBase64**
- **ConvertCamelConvention**
- **ConvertCamelConventionWithNumbers**
- **ConvertDayShortcutFullName**
- **ConvertDayShortcutString**

### Key Methods

- `ConvertTo()`
- `ConvertFrom()`
- `ToUInt16()`
- `ToUInt32()`
- `ToUInt64()`
- `To()`
- `From()`
- `IsCamel()`
- `ToConvention()`
- `IsCamelWithNumber()`

## Installation

```bash
dotnet add package SunamoConverters
```

## Dependencies

- **Microsoft.Extensions.Logging.Abstractions** (v9.0.3)

## Package Information

- **Package Name**: SunamoConverters
- **Version**: 25.6.7.1
- **Target Framework**: net9.0
- **Category**: Platform-Independent NuGet Package
- **Source Files**: 41

## Related Packages

This package is part of the Sunamo package ecosystem. For more information about related packages, visit the main repository.

## License

See the repository root for license information.

<!-- sunamo:test-coverage:start -->
## Test coverage

| Metric | Value |
|---|---|
| Method | static |
| Test projects | 1 |
| Public types referenced by tests | 3/25 (12.0 %) |
| Public methods referenced by tests | 6/23 (26.1 %) |
| Line coverage | n/a |
| Branch coverage | n/a |
| Generated (UTC) | 2026-11-22 21:24 |

<!-- sunamo:test-coverage:data {"package":"SunamoConverters","container":"pinp","testProjects":1,"publicTypes":25,"typesReferencedByTests":3,"publicMethods":23,"methodsReferencedByTests":6,"lineRate":null,"branchRate":null,"method":"static","generatedUtc":"2026-11-22 21:24"} -->
<!-- sunamo:test-coverage:end -->
