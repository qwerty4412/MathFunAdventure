using UnityEngine;

public class Falldetect : MonoBehaviour
{
    [SerializeField] private Transform Respawn;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InputsPlayer player = other.GetComponent<InputsPlayer>();

            if (player != null)
            {
            
            }


            CharacterController cont = other.GetComponent<CharacterController>();

            if (cont != null)
            {
                cont.enabled = false;
            }

            other.transform.position = Respawn.position;

            if (cont != null)
            {
                cont.enabled = true;
            }
        }
    }
}
