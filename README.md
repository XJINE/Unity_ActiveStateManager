# Unity_ActiveStateManager

![](https://github.com/XJINE/Unity_ActiveStateManager/blob/master/Screenshot01.png)

Manage objects active state.

## Import to Your Project

You can import this asset from UnityPackage.

- [ActiveStateManager.unitypackage](https://github.com/XJINE/Unity_ActiveStateManager/blob/master/ActiveStateManager.unitypackage)

### Dependencies

You have to import following assets to use this asset.

- [Unity_SingletonMonoBehaviour](https://github.com/XJINE/Unity_SingletonMonoBehaviour)

## How to Use

![](https://github.com/XJINE/Unity_ActiveStateManager/blob/master/Screenshot02.png)

1. Add ``ActiveStateManagerTarget`` into objects.
2. Add some ``key`` if you need.
3. Call some function from ``ActiveStateManager``.

```
ActiveStateManager.Instance.ActivateObjects();
ActiveStateManager.Instance.InactivateObjects();
```

If you add some keys in ActiveStateManagerTarget, you could control the objects with the key.

```
ActiveStateManager.Instance.ActivateObjects("Round");
ActiveStateManager.Instance.InactivateObjects("Round");
```

In this case, ``"Round"`` is key.