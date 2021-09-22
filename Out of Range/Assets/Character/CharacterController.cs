using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Character = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Jump()
    {

    }
}
