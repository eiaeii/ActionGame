using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class SpwanManager : MonoBehaviour {
    public EnemySpawn[] monsterSpawnArray;
    public EnemySpawn[] bossSpawnArray;

    private List<GameObject> enemyList = new List<GameObject>();
    // Use this for initialization
    void Start () {
        StartCoroutine(Spawn());
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    IEnumerator Spawn()
    {
        //第一波敌人的生成
        foreach (EnemySpawn s in monsterSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }

        while (enemyList.Count > 0)
        {
            yield return new WaitForSeconds(0.2f);
        }

        //第二波敌人的产生
        foreach (EnemySpawn s in monsterSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }
        yield return new WaitForSeconds(0.5f);
        foreach (EnemySpawn s in monsterSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }

        while (enemyList.Count > 0)
        {
            yield return new WaitForSeconds(0.2f);
        }

        //第三波敌人的产生
        foreach (EnemySpawn s in monsterSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }
        yield return new WaitForSeconds(0.5f);
        foreach (EnemySpawn s in monsterSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }
        yield return new WaitForSeconds(0.5f);
        foreach (EnemySpawn s in bossSpawnArray)
        {
            enemyList.Add(s.Spawn());
        }

        while (enemyList.Count > 0)
        {
            yield return new WaitForSeconds(0.2f);
        }
        //游戏胜利
        //AudioSource.PlayClipAtPoint(victoryClip, transform.position, 1f);
    }
}
