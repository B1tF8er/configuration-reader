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
