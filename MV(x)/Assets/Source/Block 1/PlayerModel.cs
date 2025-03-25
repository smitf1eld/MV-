using System;

namespace Source.Block_1
{
    public class PlayerModel
    {
        public event Action OnHealthChange;
        public event Action OnPlayerDeath;

        private int _maxHealth;
        private int _currentHealth;

        public PlayerModel(int maxHealth)
        {
            this._maxHealth = maxHealth;
            this._currentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            OnHealthChange?.Invoke();

            if (_currentHealth <= 0)
            {
                _currentHealth = 0;
                OnPlayerDeath?.Invoke();
            }
        }

        public int GetHealth() => _currentHealth;
        public int GetMaxHealth() => _maxHealth;
    }
}