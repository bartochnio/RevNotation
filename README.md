# RevNotation
Reverse notation for Unity3D mathematical libraries.

# Why
This script library is for people like me, who are to lazy to write
```csharp
var x = Mathf.Lerp(y, 100f, t * Time.deltaTime);<br>
x = Mathf.Clamp(x, 100f); // Not like it's needed often if you know what you are doing.
```
but you prefer
```csharp
vaf x = y.Lerp(100f, t * Time.deltaTime).Clamp(100f);
```

# How
Copy the scripts to your assets folder anywhere and at top your script add line:

```csharp
using Roargh.Rev.Floats;
```

Soon I will add simmilar lib for Vectors. At least useful ones but I am sleepy now.



