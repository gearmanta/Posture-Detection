using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public static test instance;
    public GameObject ball;
    public float span = 0.2f;///Random.Range(0f,0.50f);
    private float currentTime = 0f;
    float time = 0f;
    public float life_time = 15f;
    public bool isPlaying = true;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        {
            currentTime += Time.deltaTime;
            Transform myTransform = ball.transform;

            if (currentTime > span)
            {
                Debug.LogFormat("{0}秒経過", span);
                currentTime = 0f;

                Vector3 pos = myTransform.position;
                pos.x = Random.Range(-2f, 2f);
                pos.y = 1f;
                pos.z = 10;
                GameObject obj = Instantiate(ball, new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
                obj.SetActive(true);
                obj.transform.position = pos;  // 座標を設定
                time += Time.deltaTime;
            }
        }
        
    }
    public GameObject gameOverScreen;
    public void Reset()
    {
        isPlaying = true;
        gameOverScreen.SetActive(false);
        time = 0;
    }


    //T += Time.deltaTime;

    //if(T > 10)
    //{
    //    Instantiate(ball, new Vector3(x, y, z), Quaternion.identity);
    //}
}

