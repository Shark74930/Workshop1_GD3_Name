using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : Singleton<CharacterManager>
{
    private CharacterController _character = null;

    private event Action _jump = null;
    private event Action _grounded = null;

    public CharacterController Character
    {
        get
        {
            return _character;
        }

        set
        {
            if(_character == null)
            {
                _character = value;
            }
            else
            {
                Debug.Log("Error : Character is already set");
            }
        }
    }

    public event Action Jump
    {
        add
        {
            _jump -= value;
            _jump += value;
        }
        remove
        {
            _jump -= value;
        }
    }

    public event Action Grounded
    {
        add
        {
            _grounded -= value;
            _grounded += value;
        }
        remove
        {
            _grounded -= value;
        }
    }

}
