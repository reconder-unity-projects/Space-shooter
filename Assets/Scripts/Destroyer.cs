﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D collision) => Destroy(collision.gameObject);

}
