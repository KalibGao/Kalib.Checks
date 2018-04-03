# Kalib.Checks

basic check function 


```csharp
// it will throw ArgumentNullException
DemoClass A = null;
A.CheckNull(nameof(A));

// it will throw ArgumentNullException
string value = null;
value.CheckNull(nameof(value));
// it will throw ArgumentException
value = String.Empty;
value.CheckEmpty(nameof(value));
// it will throw ArgumentException
value = "  ";
value.CheckWhitespace(nameof(value));


// it will throw ArgumentNullException
List<int> list = null;
list.CheckEmpty(nameof(list));
// it will throw ArgumentException
List<int> list = new List<int>();
list.CheckEmpty();

```


commonly used scenarios

```csharp
// mvc dependency injection
public class HomeController : Controller {
    private readonly IDemoService _demoService;

    public HomeController(IDemoService demoService){
        // if null, throw exception
        demoService.CheckNull(nameof(_demoService));
        // asign value
        _demoService = demoService;
    }
}

// in method
public void IsMeaningfulWord(string word){
    try
    {
        word.CheckNull(nameof(word));
        return true;
    }
    catch(ArgumentNullException ex){
        return false;
    }    
}

```
