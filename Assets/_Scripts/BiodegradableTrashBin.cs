﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiodegradableTrashBin : GameManager
{

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Biodegradable"))
        {
            CorrectTrash(collision.gameObject);
        }

        else
        {
            WrongTrash(collision.gameObject);
        }

    }

}