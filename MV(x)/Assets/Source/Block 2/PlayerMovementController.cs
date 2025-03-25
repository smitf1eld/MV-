using UnityEngine;

namespace Source.Block_2
{
    public class PlayerMovementController
    {
        private PlayerMovementModel _model;
        private PlayerMovementView _view;

        public PlayerMovementController(PlayerMovementModel model, PlayerMovementView view)
        {
            _model = model;
            _view = view;
        }

        public void HandleMovement(Vector2 input)
        {
            Vector3 move = new Vector3(input.x, 0, input.y) * _model.Speed * Time.deltaTime;
            _view.MovePlayer(_view.transform.position + move);
        }
    }
}