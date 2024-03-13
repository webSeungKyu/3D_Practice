using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class PlayerHealth : MonoBehaviour
{
    //���� ü��
    public int startingHealth = 100;
    //���� ü��
    public int currentHealth;
    //ü�� UI�� ����
    public Slider healthSlidier;
    //������ �޾��� �� ȭ�� �� ����
    public Image damageImage;
    //�÷��̾� ������ �޾��� �� ����� �����
    public AudioClip deathClip;

    //�ִϸ����Ϳ� ����
    Animator anim;
    //ȿ���� Ʋ�� ���� ������Ʈ
    AudioSource playerAudio;
    //�÷��̾� ������ ����
    PlayerMovement playerMovement;

    //�÷��̾ �׾������� ���� �Ǵ�(�÷���)
    bool isDead;

    //������Ʈ ���� �� ȣ��Ǵ� Awake, Start ���� ����˴ϴ�.

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        playerMovement = GetComponent<PlayerMovement>();
        currentHealth = startingHealth;
        //healthSlidier.value = currentHealth;
    }


    /// <summary>
    /// �÷��̾ ������ �޾��� �� ȣ��Ǵ� �Լ��Դϴ�.
    /// </summary>
    /// <param name="amount">������ ��ġ</param>
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        healthSlidier.value = currentHealth;

        if (currentHealth <= 0 && !isDead)
        {
            Death();
        }
        else
        {
            anim.SetTrigger("Damage");
        }
    }

    void Death()
    {
        isDead = true;
        anim.SetTrigger("Die");
        playerMovement.enabled = false;
    }



    // Update is called once per frame
    void Update()
    {

    }



}
