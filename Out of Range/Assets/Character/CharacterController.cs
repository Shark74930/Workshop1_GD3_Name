using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rb = null;
    [SerializeField] private float _torqueForce = 0f;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Character = this;
    }

    // Update is called once per frame
    void Update()
    {
        float turn = InputManager.Instance.Rot.x;
        _rb.AddTorque(_torqueForce * turn);
    }

    public void Jump()
    {

    }
}
