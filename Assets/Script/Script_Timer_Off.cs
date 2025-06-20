using UnityEngine;

public class Script_Timer_Off : MonoBehaviour
{
    [SerializeField] private float Timer;
    [SerializeField] private float CurrentTimer;
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
            gameObject.SetActive(false);
            Timer = CurrentTimer;
        }
    }
}
