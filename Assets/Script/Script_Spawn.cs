using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives;

public class Script_Spawn : MonoBehaviour
{
    [SerializeField] private float Timer;
    [SerializeField] private float CurrentTimer;
    [SerializeField] Script_Spawn script_Spawn;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Timer > 0)
        {
            Timer -= Time.deltaTime;
        }
        else if (Timer <= 0)
        {
            GameObject Spawn = Script_ObjectPool_Cube.instance.GetObjectToPools();
            if (Spawn != null)
            {
                Spawn.transform.position = transform.position;
                Spawn.transform.rotation = transform.rotation;
                Spawn.SetActive(true);
            }
            Timer = CurrentTimer;
        }
    }
    public void On()
    {
         script_Spawn.enabled = true;
    }
    public void Off()
    {
        script_Spawn.enabled = false;
    }
}
