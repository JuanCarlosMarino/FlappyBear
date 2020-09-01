using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeAparicion : MonoBehaviour
{
    [SerializeField]public float maxTime = 3;
    private float _timer = 0;
    public GameObject pipe;

    [SerializeField]public float height ;
    //[SerializeField]public double TopHeight = 3;
    //[SerializeField]public double BottomHeight = 3;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,(height+1)),0);
    }
    // Update is called once per frame
    void Update()
    {
        if (_timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height,(height+1)),0);
            Destroy(newpipe,15);
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
}
