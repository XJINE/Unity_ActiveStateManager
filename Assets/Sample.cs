using UnityEngine;

public class Sample : MonoBehaviour
{
    public KeyCode inactivateAllKey   = KeyCode.F1;
    public KeyCode activateAllKey     = KeyCode.F2;
    public KeyCode inactivateRoundKey = KeyCode.F3;
    public KeyCode activateRoundKey   = KeyCode.F4;

    void Update()
    {
        if (Input.GetKeyDown(this.inactivateAllKey))
        {
            ActiveStateManager.Instance.InactivateObjects();
        }
        if (Input.GetKeyDown(this.activateAllKey))
        {
            ActiveStateManager.Instance.ActivateObjects();
        }
        if (Input.GetKeyDown(this.inactivateRoundKey))
        {
            ActiveStateManager.Instance.InactivateObjects("Round");
        }
        if (Input.GetKeyDown(this.activateRoundKey))
        {
            ActiveStateManager.Instance.ActivateObjects("Round");
        }
    }

    private void OnGUI()
    {
        GUILayout.Label("Press " + this.inactivateAllKey   + " : Inactivate all objects.");
        GUILayout.Label("Press " + this.activateAllKey     + " : Activate all objects.");
        GUILayout.Label("Press " + this.inactivateRoundKey + " : Inactivate round objects.");
        GUILayout.Label("Press " + this.activateRoundKey   + " : Activate round objects.");
    }

}