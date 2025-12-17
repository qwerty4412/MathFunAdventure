using UnityEditor.SearchService;
using UnityEngine;

public class Enemydamage : MonoBehaviour
{
     [SerializeField] private Transform Respawn;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider damage)
    {
        if (damage.tag == "Player")
        { 
            input player = damage.GetComponent<input>();

            if (player != null)
            {
            
            }


            CharacterController cont = damage.GetComponent<CharacterController>();

            if (cont != null)
            {
                cont.enabled = false;
            }

            damage.transform.position = Respawn.position;

            if (cont != null)
            {
                cont.enabled = true;
            }
        }
    }
}
