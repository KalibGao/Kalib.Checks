# Kalib.Checks

## basic check function 

### 1. Extension Style 
```csharp
// using reference
using Kalib.Checks.Extensions

// it will throw ArgumentNullException
DemoClass A = null;
A.NotNull(nameof(A));

// it will throw ArgumentNullException
string value = null;
value.NotNull(nameof(value));

// it will throw ArgumentException
value = String.Empty;
value.NotEmpty(nameof(value));

// it will throw ArgumentException
value = "  ";
value.NotWhitespace(nameof(value));

// it will throw ArgumentNullException
List<int> list = null;
list.NotEmpty(nameof(list));

// it will throw ArgumentException
List<int> list = new List<int>();
list.NotEmpty(nameof(list));

```

### 2. Class and Method Style

```csharp
// using reference
using Kalib.Checks

// it will throw ArgumentNullException
DemoClass A = null;
Check.NotNull(A, nameof(A));

// it will throw ArgumentNullException
string value = null;
Check.NotNull(value, nameof(value));

// it will throw ArgumentException
value = String.Empty;
Check.NotEmpty(value, nameof(value));

// it will throw ArgumentException
value = "  ";
Check.NotWhitespace(value, nameof(value));

// it will throw ArgumentNullException
List<int> list = null;
Check.NotEmpty(list, nameof(list));

// it will throw ArgumentException
List<int> list = new List<int>();
Check.NotEmpty(list, nameof(list));

```


## Commonly Used Scenarios

### 1. Extension Style 

```csharp
// mvc dependency injection
public class HomeController : Controller {
    private readonly IDemoService _demoService;

    public HomeController(IDemoService demoService){
        // if null, throw exception
        demoService.NotNull(nameof(_demoService));
        // asign value
        _demoService = demoService;
    }
}

// in method
public void IsMeaningfulWords(string words){
    try
    {
        word.NotNull(nameof(word));
        return true;
    }
    catch(ArgumentNullException ex){
        return false;
    }    
}

```

### 2. Class and Method Style

```csharp
// mvc dependency injection
public class HomeController : Controller {
    private readonly IDemoService _demoService;

    public HomeController(IDemoService demoService){
        // if null, throw exception
        Check.NotNull(demoService, nameof(_demoService));
        // asign value
        _demoService = demoService;
    }
}

// in method
public void IsMeaningfulWords(string words){
    try
    {
        Check.NotNull(words, nameof(word));
        return true;
    }
    catch(ArgumentNullException ex){
        return false;
    }    
}

```