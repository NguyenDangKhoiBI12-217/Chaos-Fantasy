using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "ScriptableObjects/Character")]
public class CharacterData : ScriptableObject
{
    [SerializeField]
    private Sprite playerSprite;
    public Sprite PlayerSprite { get => playerSprite; private set => playerSprite = value; }

    public RuntimeAnimatorController animationController;

    [SerializeField]
    private GameObject startingWeapon;
    public GameObject StartingWeapon { get => startingWeapon; private set => startingWeapon = value; }

    [SerializeField]
    private float maxHealth;
    public float MaxHealth { get => maxHealth; private set => maxHealth = value; }

    [SerializeField]
    private float moveSpeed;
    public float MoveSpeed { get => moveSpeed; private set => moveSpeed = value; }

    [SerializeField]
    private float recovery;
    public float Recovery { get => recovery; private set => recovery = value; }

    [SerializeField]
    private float might;
    public float Might { get => might; private set => might = value; }

    [SerializeField]
    private float projectileSpeed;
    public float ProjectileSpeed { get => projectileSpeed; private set => projectileSpeed = value; }

    [SerializeField]
    private float magnet;
    public float Magnet { get => magnet; private set => magnet = value; }

    [SerializeField]
    private float cooldownReduction;
    public float CooldownReduction { get => cooldownReduction; private set => cooldownReduction = value; }
}
