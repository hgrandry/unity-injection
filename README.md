# Unity Injection

Minimalist depency injection for Unity.

[Examples](https://github.com/hgrandry/unity-examples/tree/master/Assets/Injection)

```csharp
public class MyService : MonoBehaviour, IInjectable
{
  public event Action AnEventRaised;
  public void DoStuff() { }

  // register when your service is ready to use, or extends Injectable<T> to auto register/unregister.
  private void OnEnable() { this.Register(); }
  private void OnDisable() { this.Unregister(); }
}

public class MyComponent : MonoBehaviour
{
  private void Awake()
  {
    this.Require<MyService>(service =>
    {
        service.DoStuff();
        service.AnEventRaised += MyCallBack;

        // optionally return a cleanup method to detach from what we attached to in the init once MyComponent is destroyed.
        return () => { service.AnEventRaised -= MyCallBack;  };
    });
  }

  private void MyCallBack() {}
}
```

# Motivation

### Better control of what is in memory.

You have probably seen or use this many times:

```csharp
MyClass.Instance.DoSomething();
```

No offense, but friends this is a recipe for spagetthi-style disaster: access anything anywhere, potential circular dependencies. It also makes it really hard to track what is loaded at a given time, and what should not be loaded but is still in memory because, arg, someone forgot to dereferenced it somewhere...

With dependency injection there is one static container, the dependency solver (sometime called service provider, or just Bill if you are close). Everything else, so all your actual project code, is local and disposable. You can load a class instance, or service, when you need it and then unload it when you don't need it anymore.

You still have to track references, there is not much way around it, but you stay much more in control how what is loaded in memory, and it's pretty much free to just unload all your application modules to free memory and reload them when needed.

### Explicit dependencies between components

Dependency injection makes dependencies between your components explicit and therefore easier to track. You can log what modules are loaded in the dependency solver, or what component is referening a particular service. If there is a dangling reference somewhere, it's much easier to find and resolve.

### Minimalist approach

Although there are already solution for dependency injection in Unity out there, I wanted to take a minimalist approach and design only for what I needed at the time, instead of going with a full blown framework.

So, if you prefer to roll your own way instead of using this library, just pick and choose what makes sense for you and your project. I'm sure you can find one or two ideas in there that can be of interest.
