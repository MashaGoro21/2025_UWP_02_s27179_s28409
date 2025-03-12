using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Enemy
{
	public class Enemy : MonoBehaviour
	{
	    public int health = 100;
	    void Update()
	    {
	        transform.Translate(Vector3.forward * Time.deltaTime);
	    }
	}
}