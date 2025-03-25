using Source.Block_2;
using UnityEngine;

namespace Source.Input
{
    public class InputListener : MonoBehaviour
    {
        private PlayerMovementController _movementController;

        void Start()
        {
            var movementModel = new PlayerMovementModel();
            var movementView = GetComponent<PlayerMovementView>();
            _movementController = new PlayerMovementController(movementModel, movementView);
        }

        void Update()
        {
            float horizontal = UnityEngine.Input.GetAxis("Horizontal");
            float vertical = UnityEngine.Input.GetAxis("Vertical");

            _movementController.HandleMovement(new Vector2(horizontal, vertical));
        }
    }
}