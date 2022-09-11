using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField] Slider oilbar;
    [SerializeField] Image fill;
    [SerializeField] GameObject Introduction;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        oilbar.maxValue = CharacterController.Instance.maxOil;
        oilbar.minValue = 0f;
        oilbar.value = CharacterController.Instance.oil;
    }

    // Update is called once per frame
    void Update()
    {
        oilbar.value = CharacterController.Instance.oil;
    }

    public void Intro(bool Start)
    {
        if (Start)
        {
            Introduction.SetActive(true);
        }
        else
        {
            Introduction.SetActive(false);
        }
    }
}
