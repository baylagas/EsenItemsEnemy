using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public GameObject enemyBullet;
    public float shootStartTime;
    public float changeInterval;
    public float tellInterval;
    public float shootInterval;
    public Sprite negative;

    private SpriteRenderer spRender;

    void Awake()
    {
        spRender = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        StartCoroutine("ShootingStart");
    }

    public IEnumerator ShootingStart()
    {
        yield return new WaitForSeconds(shootStartTime);
        Debug.Log("start shooting!");
        while(true)
        {
            yield return new WaitForSeconds(shootInterval);
            //start with tell
            Sprite original = spRender.sprite;
            spRender.sprite = negative;
            yield return new WaitForSeconds(changeInterval);
            spRender.sprite = original;
            yield return new WaitForSeconds(tellInterval);
            //finish with tell

            CanShoot();
            Debug.Log("shoot!");
        }
    }

    private void CanShoot()
    {
        Instantiate(enemyBullet, transform.position, Quaternion.identity);
    }
}
