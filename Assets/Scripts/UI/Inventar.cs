using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour
{
    public static Inventar Singleton;
    [SerializeField] GameObject Key;
    bool _isactive=false;

    private void Awake()
    {
        Singleton = this;
    }
    public void activateKey()
    {
        Key.SetActive(true);
        _isactive=true;
    }

    public void deactivateKey()
    {
        Key.SetActive(false);
        _isactive=false;
    }

    public bool isActive()
    {
        return _isactive;
    }
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
