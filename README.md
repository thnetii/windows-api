# TH-NETII Windows API

.NET P/Invoke binding for the Windows API

|Pipeline|Latest build|
|-|-|
|CI Build pipeline|[![windows-api-ci](https://dev.azure.com/thnetii/windows-api/_apis/build/status/windows-api-ci?branchName=master)](https://dev.azure.com/thnetii/windows-api/_build/latest?definitionId=7&branchName=master)|
|CI Nightly artifacts|![TH-NETII Windows API (Nightly)](https://vsrm.dev.azure.com/thnetii/_apis/public/Release/badge/23392c0f-994a-4dc0-8d9a-82ed7d31a77d/1/2)|
|Azure DevOps artifacts|![TH-NETII Artifacts](https://vsrm.dev.azure.com/thnetii/_apis/public/Release/badge/23392c0f-994a-4dc0-8d9a-82ed7d31a77d/1/1)|
|NuGet|N/A|

This repository contains a number of projects organised by the native Header 
files in the Windows SDK.

## Versioning

All packages created from this repository will have the same major, minor and
patch version number. The version of the package is determined by the Windows
SDK version used as reference for the package.

Currently, this repository uses version `10.0.17134` of the Windows SDK as
a reference.

## How-to-use

### NuGet.org

In the future, the packages created from this repository and all their 
dependencies will be published on NuGet.

### TH-NETII Artifacts NuGet feed

Releases of the packages in this respository are automatically published to
the [TH-NETII Artifacts public feed](https://dev.azure.com/thnetii/artifacts/_packaging?_a=feed&feed=public)
on Azure DevOps.

Refer to the [instructions](https://dev.azure.com/thnetii/artifacts/_packaging?_a=connect&feed=public) 
on AzureDev Ops on how to connect to this feed.

The automatic release pipeline is configured to deploy commits made to branches
matching the wildcard name `rel/*` to this feed automatically.

### Nightly CI feed

Commits to the `master` branch are automatically deployed to the CI feed for
this repository. [TH-NETII Windows API CI Feed](https://dev.azure.com/thnetii/windows-api/_packaging?_a=feed&feed=windows-api-ci)

Refer to the [instructions](https://dev.azure.com/thnetii/windows-api/_packaging?_a=connect&feed=windows-api-ci) 
on AzureDev Ops on how to connect to this feed.

Note that version numbers for the non-release CI build always have a `build<build-id>`
suffix marking them as pre-release packages. The `build-id` is sequential and
uses the Azure DevOps Build ID for the build that generated the package.

### Git submodule

This repository uses a default .NET Core build. You can therefore directly
use this repository as a submodule if you want. *Note that keeping submodules up
to date comes with challenges, generally using a package manager is recommended.*

``` sh
git submodule add https://github.com/thnetii/windows-api.git
```

## Source structure

In addition to the usual `src`/`test` directories, this repository also 
includes some additional directories.

### src-native

The `src-native` subdirectory contains the thin P/Invoke wrappers around the 
Windows APIs located in the various headers files of the Windows SDK.

The declarations and definitions in a C Header file are generally mapped using
the following guidelines:

* Constant preprocessor definitions and constant expressions that can be
  translates into a constant C# expression are declared as a constant member.  
  The constant member is declared within a static class named `<Header>Constants`.  
  If there is a sufficient number of constants to be declared, the class should
  be located in a seperate project named `THNETII.WinApi.Constants.<Header>`.  
  Otherwise, the class is located within a project named `THNETII.WinApi.Headers.<Header>`  
  `<Header>` is the basename of the header file
  declaring the constant.
* Constants that can be mapped to types that are not C# primitive types (e.g.
  `GUID` &rightarrow; `System.Guid`) are declared as static read-only members.  
  If the header has an associated `THNETII.WinApi.Constants.<Header>` project,
  the static members are declared in a static class named
  `<Header>RuntimeConstants` within the `THNETII.WinApi.Headers.<Header>`
  project.  
  In case the constant can be expressed in a primitive expression **and** is
  convertible to a non-primitive type, the primitive symbol declaration can be
  placed in the `THNETII.WinApi.Constants.<Header>` project (if it exists) and
  the static initializer of the non-primitive expression should make use of the
  primitive constant.
* Macro preprocessor definitions are considered to be non-external static
  functions and are placed in the `THNETII.WinApi.Headers.<Header>` project
  within a `<Header>Functions` static class.  
  If there are a sufficient number of macro definitions to be declared,
  consider placing the function in a `<Header>Macros` static class.
* Struct, Union and Enumeration type declarations (and typedefs) are declared as
  regular C# types.  
  Structures and Unions are declared as `struct` types with the `StructLayout`
  attribute applied to the declared type. Structures use the sequential layout
  kind; unions use the explicit layout kind with all fields using a field offset
  of `0` (zero).
* Documentation comments should use usual triple-slash C# comments. Oftentimes
  the API documentation from docs.microsoft.com will contain references to other
  members across different projects. If these references that are purely for
  documentation purposes, consider adding a `PrivateAssets="All"` project
  reference. If this would lead to a circular reference, use a fully qualified
  type prefix reference.
* Documentation comments for overloads should use ambiguous cref references with
  only the method name being specified. For that reason, overload definitions
  should place the most common overload first in the source code. Suppress 
  warning `CS0419` in the project file and GlobalSuppressions.
* Functions taking or returning string-type arguments should order the 
  string-marshalling variants before the `LPSTR` (and related) variants.

### symbols

Located in the `symbols/Windows.System32` subdirectory are text files
containing the output of the `dumpbin.exe` tool that is part of the
Visual Studio Tools.

You can use a text search tool to find the DLL that exports a certain function.
This is useful for finding the DLL to import when a declared function has no
associated documentation page on docs.microsoft.com or if the DLL name is
missing from the documentation.

### src-native-c

Located in the `src-native-c` subdirectory, there is a Visual C++ project
used for testing and reference of native C sources. The solution file also
references this project file and as a consequence running `dotnet build` on
the repository root level (or specifying the solution fiel as the project) will 
lead to an error message on compilation. Building the C-project is not crucial
to the packages in this repository and thus all errors regarding the native c
project can safely be ignored.
