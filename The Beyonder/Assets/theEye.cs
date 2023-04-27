using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theEye : MonoBehaviour
{
    private SpriteRenderer sprite;
    private SpriteMask mask;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        mask = GetComponent<SpriteMask>();
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
            sprite.enabled = true;
            mask.enabled = true;
		}else if (Input.GetMouseButtonDown(1))
		{
            sprite.enabled = false;
            mask.enabled = false;
		}
    }
}
