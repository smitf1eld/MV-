using Source.Block_1;
using Source.Player;
using UnityEngine;

namespace Source.Block_3
{
    public class PlayerCollisionHandler : MonoBehaviour
    {
        private PlayerController _playerController;

        void Start()
        {
            _playerController = GetComponent<PlayerController>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                _playerController.TakeDamage(10);  
            }
        }
    }
}