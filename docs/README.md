# Configuration Reader #

It is a library to help you get in a succinct way the `app.config` values.

It uses .NET 4.8 and only works with .NET Framework projects

The types supported so far are the ones listed [here](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types). Except for `object`

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
    <add key="SByte" value="0123"/>
    <add key="Short" value="6"/>
    <add key="String" value="test"/>
    <add key="UInt" value="7"/>
    <add key="ULong" value="8"/>
    <add key="UShort" value="9"/>
  </appSettings>
</configuration>

```
The way to access the `app settings` would be like this:

```csharp
namespace Sample
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
            // boolSetting.Parsed == True; boolSetting.Value == True; boolSetting.Error == string.Empty

            var byteSetting = "Byte".TryGetByteSetting();
            // byteSetting.Parsed == True; byteSetting.Value == 0123; byteSetting.Error == string.Empty
            
            var charSetting = "Char".TryGetCharSetting();
            // charSetting.Parsed == True; charSetting.Value == 'a'; charSetting.Error == string.Empty
            
            var decimalSetting = "Decimal".TryGetDecimalSetting();
            // decimalSetting.Parsed == True; decimalSetting.Value == 1.9M; decimalSetting.Error == string.Empty
            
            var doubleSetting = "Double".TryGetDoubleSetting();
            // doubleSetting.Parsed == True; doubleSetting.Value == 2.9D; doubleSetting.Error == string.Empty
            
            var floatSetting = "Float".TryGetFloatSetting();
            // floatSetting.Parsed == True; floatSetting.Value == 3.9F; floatSetting.Error == string.Empty
            
            var intSetting = "Int".TryGetIntSetting();
            // intSetting.Parsed == True; intSetting.Value == 4; intSetting.Error == string.Empty
            
            var longSetting = "Long".TryGetLongSetting();
            // longSetting.Parsed == True; longSetting.Value == 5; longSetting.Error == string.Empty
            
            var sByteSetting = "SByte".TryGetSByteSetting();
            // sByteSetting.Parsed == True; sByteSetting.Value == 0123; sByteSetting.Error == string.Empty
            
            var shortSetting = "Short".TryGetShortSetting();
            // shortSetting.Parsed == True; shortSetting.Value == 6; shortSetting.Error == string.Empty
            
            var stringSetting = "String".TryGetStringSetting();
            // stringSetting.Parsed == True; stringSetting.Value == "test"; stringSetting.Error == string.Empty
            
            var uIntSetting = "UInt".TryGetUIntSetting();
            // uIntSetting.Parsed == True; uIntSetting.Value == 7; uIntSetting.Error == string.Empty
            
            var uLongSetting = "ULong".TryGetULongSetting();
            // uLongSetting.Parsed == True; uLongSetting.Value == 8L; uLongSetting.Error == string.Empty
            
            var uShortSetting = "UShort".TryGetUShortSetting();
            // uShortSetting.Parsed == True; uShortSetting.Value == 9; uShortSetting.Error == string.Empty
        }

        public void Errors()
        {
            var boolSetting = "Test_Error".TryGetBoolSetting();
            // boolSetting.Parsed == False; boolSetting.Value == default(bool); boolSetting.Error == "The key: TEST_ERROR does not exist in the configuration file."

            var charSetting = "Boolean".TryGetCharSetting();
            // charSetting.Parsed == False; charSetting.Value == default(char); charSetting.Error == "The configuration value for key: BOOLEAN could not be parsed."
        }
    }
}
```
