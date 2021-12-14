# ClasslibWithControllersExample

Simple example of adding a controller from another project file.

The project api/api.csproj is the default weatherforecast project template, but with a dependency on classlib/classlib.csproj and the following added to api/Program.cs

```csharp
var otherassembly = typeof(classlib.othercontroller).Assembly;
builder.Services.AddControllers().AddApplicationPart(otherassembly);
```

The controller is defined in classlib/othercontroller.cs

It is added in Program.cs at line 6

Dependencies are managed in classlib/classlib.csproj, api/api.csproj and ClasslibWithControllers.sln


`GET:/classlib/other` will yield the payload `"hi"`