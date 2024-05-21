using UnityEngine;

public class Stats {
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
        }
    }
}
