using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorScript : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("junk"))
        {
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag.Equals("gunk"))
        {
            Destroy(other.gameObject);

        }


    }
}
