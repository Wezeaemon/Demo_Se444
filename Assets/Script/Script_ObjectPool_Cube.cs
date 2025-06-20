using System.Collections.Generic;
using UnityEngine;

public class Script_ObjectPool_Cube : MonoBehaviour
{
    public static Script_ObjectPool_Cube instance;
    [SerializeField] GameObject Cube;
    [SerializeField] private int Amount;
    private List<GameObject> ObjectPools = new List<GameObject>();
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        for (int i = 0; i < Amount; i++)
        {
            GameObject Obj = Instantiate(Cube);
            Obj.SetActive(false);
            ObjectPools.Add(Obj);
        }
    }

    // Update is called once per frame
    public GameObject GetObjectToPools()
    {
        for (int i = 0; i < ObjectPools.Count; i++)
        {
            if (!ObjectPools[i].activeInHierarchy)
            {
                return ObjectPools[i];
            }
        }
          return null;
    }
}
