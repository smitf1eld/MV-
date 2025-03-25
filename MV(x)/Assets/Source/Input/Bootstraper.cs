using Source.Block_1;
using UnityEngine;

namespace Source.Player
{
    public class Bootstrapper : MonoBehaviour
    {
        public PlayerView playerView;
        public GameObject playerPrefab;

        void Start()
        {
            var playerModel = new PlayerModel(100);  // Максимальное здоровье
            var playerController = new PlayerController(playerModel, playerView);

            var playerInstance = Instantiate(playerPrefab);
            playerView = playerInstance.GetComponent<PlayerView>();  // Привязываем представление

            playerController.TakeDamage(10);  // Пример использования
        }
    }
}