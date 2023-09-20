using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject fake;
    [SerializeField] private GameObject real;
    // Start is called before the first frame update
    void Start()
    {
        fake.SetActive(true);
        real.SetActive(false);
    }

    public void Show()
    {
        fake.SetActive(false);
        real.SetActive(true);
    }
}
