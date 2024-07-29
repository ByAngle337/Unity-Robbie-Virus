using UnityEngine;

public class BottomBorderCntrl : MonoBehaviour
{
    public Transform player;
    private Transform trans;

    private void Start()
    {
        trans = transform;
    }

    private void Update()
    {
        trans.position = new Vector3(player.position.x, trans.position.y, player.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCntrl.Instance.Restart();
        }
    }
}
