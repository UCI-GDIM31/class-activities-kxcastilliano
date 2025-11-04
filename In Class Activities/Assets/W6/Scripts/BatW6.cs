using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _batspeed = 3.5;
    private Transform _player;

    public void EnableChase(Transform player)
    { enabled = true;
    _playerTransform = player;}

    public void DisableChase()
    { EnableChase = false;}

    private void Update()
    { transform.position = Vector3.MoveTowards(transform.position, _playerTransform.position, _batspeed * Time.deltaTime); }}
    


}
