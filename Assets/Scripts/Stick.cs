using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Golf
{

    public class Stick : MonoBehaviour
    {
        public UnityEvent<Collider> onCollison;

        private void OnCollisionEnter(Collision collision)
        {
            onCollison.Invoke(collision.collider);
        }
    }
}