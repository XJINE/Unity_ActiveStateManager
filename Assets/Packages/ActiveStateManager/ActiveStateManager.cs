using UnityEngine;

public class ActiveStateManager : SingletonMonoBehaviour<ActiveStateManager>
{
    #region Field

    protected ActiveStateManagerTarget[] targets;

    #endregion Field

    #region Method

    public virtual void Start()
    {
        UpdateTargets();
    }

    public virtual void UpdateTargets()
    {
        this.targets = GameObject.FindObjectsOfType<ActiveStateManagerTarget>();
    }

    public virtual void ActivateObjects()
    {
        SetActives(true);
    }

    public virtual void InactivateObjects()
    {
        SetActives(false);
    }

    public virtual void ActivateObjects(params string[] keys)
    {
        SetActives(true, keys);
    }

    public virtual void InactivateObjects(params string[] keys)
    {
        SetActives(false, keys);
    }

    protected void SetActives(bool active)
    {
        foreach (var target in this.targets)
        {
            target.gameObject.SetActive(active);
            continue;
        }
    }

    protected void SetActives(bool active, params string[] keys)
    {
        foreach (var target in this.targets)
        {
            foreach (var key in keys)
            {
                if (target.keys.Contains(key))
                {
                    target.gameObject.SetActive(active);
                    continue;
                }
            }
        }
    }

    #endregion Method
}