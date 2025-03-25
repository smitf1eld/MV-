namespace Source.Block_1
{
    public class PlayerController
    {
        private PlayerModel _model;
        private PlayerView _view;

        public PlayerController(PlayerModel model, PlayerView view)
        {
            this._model = model;
            this._view = view;

            this._model.OnHealthChange += UpdateHealthDisplay;
            this._model.OnPlayerDeath += HandlePlayerDeath;
        }

        private void UpdateHealthDisplay()
        {
            _view.UpdateHealthDisplay(_model.GetHealth(), _model.GetMaxHealth());
        }

        private void HandlePlayerDeath()
        {
            _view.UpdatePlayerAppearance(true);
        }

        public void TakeDamage(int damage)
        {
            _model.TakeDamage(damage);
        }
    }
}