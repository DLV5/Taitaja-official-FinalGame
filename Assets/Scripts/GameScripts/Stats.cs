using UnityEngine;

public class Stats : MonoBehaviour {
    private int _maxHunger = 10;
    private int _hunger = 10;
    public int Hunger { get => _hunger; set {
            if (value > _maxHunger)
            {
                _hunger = _maxHunger;
            } else
            {
                _hunger = value;
            }

            _hungerBar.SetValue(_hunger);
        }
    }
    
    private int _maxWater = 10;
    private int _water = 10;
    public int Water { get => _water; set {
            if (value > _maxWater)
            {
                _water = _maxWater;
            } else
            {
                _water = value;
            }

            _waterBar.SetValue(_water);
        }
    }
    
    private int _maxHealth = 10;
    private int _health = 10;
    public int Health { get => _health; set {
            if (value > _maxHealth)
            {
                _health = _maxHealth;
            } else
            {
                _health = value;
            }

            _healthBar.SetValue(_health);
        }
    }

    [SerializeField] private ObjectHUD _hungerBar;
    [SerializeField] private ObjectHUD _waterBar;
    [SerializeField] private ObjectHUD _healthBar;

    private void Start()
    {
        _hungerBar.SetHUD(_maxHunger, _hunger);
        _waterBar.SetHUD(_maxWater, _water);
        _healthBar.SetHUD(_maxHealth, _health);
    }
}
