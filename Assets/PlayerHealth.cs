using RengeGames.HealthBars;
using UnityEngine;

public class PlayerHealth : HealthController
{
    [SerializeField] private RadialSegmentedHealthBar _healthbar;

    protected override void OnAwake()
    {
        base.OnAwake();
        UpdateHealthBar();
    }

     public override void TakeDamage(float damage)
     {
         base.TakeDamage(damage);
         UpdateHealthBar();
         Debug.Log(_health);
     }

    public override void GetHeal(float heal)
    {
        base.GetHeal(heal);
        UpdateHealthBar();
    }
    private void UpdateHealthBar()
    {
        _healthbar.SetPercent(_health/_maxHealth);
    }
}
