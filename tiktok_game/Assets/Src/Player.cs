using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    private string enemyName;

    private GameObject restObject;
    private GameObject restDamagedObject;
    private GameObject attackObject;

    private GameObject hpBarOject;
    private Slider hpBar;
    private Image hpBarFill;
    private TMP_Text currentHpTMP;

    private GameObject enemyScoreObject;
    private TMP_Text enemyScoreTMPComponent;

    private GameObject damagedPopupObject;
    private TMP_Text damagedPopupTMP;

    //private Sound_Effect soundEffectScript;

    [SerializeField] private float attackTime = .2f;
    public float restTime = .3f;

    private void Awake()
    {
        enemyName = transform.name.Contains("Ronaldo") ? "Messi" : "Ronaldo";

        restObject = transform.Find("Rest").gameObject;
        restDamagedObject = transform.Find("Rest Damaged").gameObject;
        attackObject = transform.Find("Attack").gameObject;

        hpBarOject = GameObject.FindGameObjectWithTag("Hp Bar Container").transform.Find($"{transform.name} Hp").gameObject;
        hpBar = hpBarOject.GetComponent<Slider>();
        hpBarFill = hpBarOject.transform.Find("Fill").GetComponent<Image>();
        currentHpTMP = hpBarOject.GetComponentInChildren<TMP_Text>();

        enemyScoreObject = GameObject.FindGameObjectWithTag("Score Container").transform.Find($"{enemyName} Score").gameObject;
        enemyScoreTMPComponent = enemyScoreObject.GetComponent<TMP_Text>();

        damagedPopupObject = GameObject.FindGameObjectWithTag("Damaged Popup Container").transform.Find($"{transform.name} Damaged").gameObject;
        damagedPopupTMP = damagedPopupObject.GetComponent<TMP_Text>();
     
        //soundEffectScript = GameObject.FindGameObjectWithTag("Sound Effect").GetComponent<Sound_Effect>();
    }

    private void Start()
    {
        hpBar.value = 1;

        currentHpTMP.text = (hpBar.value * 100).ToString();

        damagedPopupObject.SetActive(false);

        restObject.SetActive(true);
        restDamagedObject.SetActive(false);
        attackObject.SetActive(false);
    }

    private void ChangeColorHpBar()
    {
        if (hpBar.value >= .7) hpBarFill.color = Color.green;
        else if (hpBar.value < .7 && hpBar.value >= .3) hpBarFill.color = Color.yellow;
        else hpBarFill.color = Color.red;
    }

    private void Dead()
    {
        if (hpBar.value <= 0)
        {
            enemyScoreTMPComponent.text = (int.Parse(enemyScoreTMPComponent.text) + 1).ToString();
            hpBar.value = 1;
            currentHpTMP.text = (hpBar.value * 100).ToString();
        }
    }

    private void Rest()
    {
        restObject.SetActive(true);
        restDamagedObject.SetActive(false);
        attackObject.SetActive(false);

        //soundEffectScript.StopBonk();
    }

    public void Attack()
    {
        restObject.SetActive(false);
        //restDamagedObject.SetActive(false);
        attackObject.SetActive(true);

        //soundEffectScript.StopBonk();
        //soundEffectScript.PlayBonk();

        Invoke(nameof(Rest), attackTime);
    }

    public void Damaged(float damage)
    {
        restObject.SetActive(false);
        restDamagedObject.SetActive(true);
        //attackObject.SetActive(false);

        hpBar.value -= damage;
        currentHpTMP.text = Mathf.CeilToInt((hpBar.value * 100)).ToString();

        damagedPopupObject.SetActive(true);
        damagedPopupTMP.text = (damage * 100).ToString();

        Dead();
        ChangeColorHpBar();

        Invoke(nameof(Rest), attackTime);
    }
}
