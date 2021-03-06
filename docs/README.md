# Configuration Reader #

It is a library to help you get in a succinct way the `app.config` values.

It uses .NET 4.8 and only works with .NET Framework projects

The types supported so far are the ones listed [here](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types).

## How To Use ##

```csharp
namespace Sample
{
    // Call it with `using static` directive. Since all public methods are static
    using static ConfigurationManagerExtensions;

    public class Test
    {
        public void It()
        {
            var key = "Some_Key_In_AppSettings";

            // This will create a SettingResponse<bool>
            // All its properties are readonly
            var boolSetting = key.TryGetBoolSetting();

            // If it was parsed
            if (boolSetting.IsParsed)
            {
                // Do something with its value
                var value = boolSetting.Value;
            }
            else
            {
                // Read the error
                var error = boolSetting.Error;
            }

            // And that is pretty much the same for all other types
        }
    }
}
```

## Samples ##

Given an `app.config` file like this:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="Boolean" value="true"/>
    <add key="Byte" value="0123"/>
    <add key="Char" value="a"/>
    <add key="Decimal" value="1.9"/>
    <add key="Double" value="2.9"/>
    <add key="Float" value="3.9"/>
    <add key="Int" value="4"/>
    <add key="Long" value="5"/>
    <add key="Object" value="{ Number : 10, Text : \"Awesome\" }"/>
    <add key="SByte" value="0123"/>
    <add key="Short" value="6"/>
    <add key="String" value="test"/>
    <add key="UInt" value="7"/>
    <add key="ULong" value="8"/>
    <add key="UShort" value="9"/>
  </appSettings>
</configuration>
```

Given a class like this to map the object:

```csharp
namespace Configuration.Reader
{
    public class Sample
    {
        public int Number { get; set; }

        public string Text { get; set; }
    }
}
```

The way to access the `app settings` would be like this:

```csharp
namespace Configuration.Reader
{
    using static ConfigurationManagerExtensions;

    public class Test
    {
        public void It()
        {
            HappyPath();
            Errors();
        }

        public void HappyPath()
        {
            var boolSetting = "Boolean".TryGetBoolSetting();
            // boolSetting.IsParsed == True;
            // boolSetting.Value == True;
            // boolSetting.Error == string.Empty

            var byteSetting = "Byte".TryGetByteSetting();
            // byteSetting.IsParsed == True;
            // byteSetting.Value == 0123;
            // byteSetting.Error == string.Empty
            
            var charSetting = "Char".TryGetCharSetting();
            // charSetting.IsParsed == True
            // charSetting.Value == 'a';
            // charSetting.Error == string.Empty
            
            var decimalSetting = "Decimal".TryGetDecimalSetting();
            // decimalSetting.IsParsed == True;
            // decimalSetting.Value == 1.9M;
            // decimalSetting.Error == string.Empty
            
            var doubleSetting = "Double".TryGetDoubleSetting();
            // doubleSetting.IsParsed == True;
            // doubleSetting.Value == 2.9D;
            // doubleSetting.Error == string.Empty
            
            var floatSetting = "Float".TryGetFloatSetting();
            // floatSetting.IsParsed == True;
            // floatSetting.Value == 3.9F;
            // floatSetting.Error == string.Empty
            
            var intSetting = "Int".TryGetIntSetting();
            // intSetting.IsParsed == True;
            // intSetting.Value == 4;
            // intSetting.Error == string.Empty
            
            var longSetting = "Long".TryGetLongSetting();
            // longSetting.IsParsed == True;
            // longSetting.Value == 5;
            // longSetting.Error == string.Empty

            var objectSetting = "Object".TryGetObjectSetting<Sample>();
            // longSetting.IsParsed == True;
            // longSetting.Value == {Configuration.Reader.Sample};
            // longSetting.Error == string.Empty
            
            var sByteSetting = "SByte".TryGetSByteSetting();
            // sByteSetting.IsParsed == True;
            // sByteSetting.Value == 0123;
            // sByteSetting.Error == string.Empty
            
            var shortSetting = "Short".TryGetShortSetting();
            // shortSetting.IsParsed == True;
            // shortSetting.Value == 6;
            // shortSetting.Error == string.Empty
            
            var stringSetting = "String".TryGetStringSetting();
            // stringSetting.IsParsed == True;
            // stringSetting.Value == "test";
            // stringSetting.Error == string.Empty
            
            var uIntSetting = "UInt".TryGetUIntSetting();
            // uIntSetting.IsParsed == True;
            // uIntSetting.Value == 7;
            // uIntSetting.Error == string.Empty
            
            var uLongSetting = "ULong".TryGetULongSetting();
            // uLongSetting.IsParsed == True;
            // uLongSetting.Value == 8L;
            // uLongSetting.Error == string.Empty
            
            var uShortSetting = "UShort".TryGetUShortSetting();
            // uShortSetting.IsParsed == True;
            // uShortSetting.Value == 9;
            // uShortSetting.Error == string.Empty
        }

        public void Errors()
        {
            var boolSetting = "Test_Error".TryGetBoolSetting();
            // boolSetting.IsParsed == False;
            // boolSetting.Value == default(bool);
            // boolSetting.Error == "The key: TEST_ERROR does not exist in the configuration file."

            var charSetting = "Boolean".TryGetCharSetting();
            // charSetting.IsParsed == False;
            // charSetting.Value == default(char);
            // charSetting.Error == "The configuration value for key: BOOLEAN could not be parsed."
        }
    }
}
```
