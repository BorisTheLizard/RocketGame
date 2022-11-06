using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 2f;
    [SerializeField] AudioClip finishLevel;
    [SerializeField] AudioClip secretSound;
    [SerializeField] AudioClip crashSound;
    [SerializeField] Animator anim;

    [SerializeField] ParticleSystem successParticles;
    [SerializeField] ParticleSystem crashParticles;
    [SerializeField] ParticleSystem thruStingParts;
    [SerializeField] Light deathLight;

    [SerializeField] GameObject[] rocketParts;
    [SerializeField] GameObject self;
    GameObject ButtonAcelerate;
    GameObject buttonHolder;

    AudioSource audioSource;

    bool isTransitioning = false;
    bool collisionDisabled = false;

    public float radius = 5.0F;
    public float power = 10.0F;

    void Start()

    {
        buttonHolder = GameObject.Find("buttonHolder");
        audioSource = GetComponent<AudioSource>();
        ButtonAcelerate = GameObject.Find("ButtonAccelerate");
    }
    void Update()
    {
        RespondToDebugKeys();
    }
    void RespondToDebugKeys()
    {
        if (Input.GetKey(KeyCode.L))
        {
            LoadNextLevel();
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            collisionDisabled = !collisionDisabled;
            Debug.Log("Cheat");
        }
    }


    void OnCollisionEnter(Collision other)
    {
        ColissionLogic(other);
    }

    private void ColissionLogic(Collision other)
    {
        if (isTransitioning || collisionDisabled) { return; }

        switch (other.gameObject.tag)
        {
            case "Secret":
                audioSource.PlayOneShot(secretSound);
                break;
            case "Friendly":
                break;
            case "Finish":
                StartSuccessSequence();
                //ButtonAcelerate.SetActive(false);
                MobileController.Thrusting = false;
                Handheld.Vibrate();
                break;
            default:
                StartCrashSequence();
                //ButtonAcelerate.SetActive(false);
                MobileController.Thrusting = false;
                Handheld.Vibrate();
                break;
        }
    }
  
    void StartSuccessSequence()
    {
        NextLevelStart();
    }

    private void NextLevelStart()
    {
        buttonHolder.SetActive(false);
        TimeManager.SlowTime = false;
        TimeManager.timeToSlowdown = false;
        MobileController.slowTimeBool = false;
        TimeManager.SlowTime = false;
        isTransitioning = true;
        audioSource.Stop();
        audioSource.PlayOneShot(finishLevel);
        successParticles.Play();
        thruStingParts.Stop();
        self.transform.localScale = new Vector3(0.01f, 0.01f, 0.01f);
        GetComponent<RocketMovement>().enabled = false;
        Invoke("LoadNextLevel", levelLoadDelay);
    }
    void StartCrashSequence()
    {
        buttonHolder.SetActive(false);
        TimeManager.SlowTime = false;
        TimeManager.timeToSlowdown = false;
        MobileController.slowTimeBool = false;
        TimeManager.SlowTime = false;
        anim.SetTrigger("boom");
        {
        
            isTransitioning = true;

            foreach(GameObject parts in rocketParts)
            {
                parts.transform.parent = null;
                parts.AddComponent<Rigidbody>();
                parts.GetComponent<Rigidbody>().mass = 30;
                parts.GetComponent<MeshCollider>().enabled = true;

                Vector3 explosionPos = transform.position;
                Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
                foreach (Collider hit in colliders)
                {
                    Rigidbody rb = hit.GetComponent<Rigidbody>();

                    if (rb != null)
                        rb.AddExplosionForce(power, explosionPos, radius, 5000.0F);
                }
            }
            audioSource.Stop();
            audioSource.PlayOneShot(crashSound);
            crashParticles.Play();
            thruStingParts.Stop();
            deathLight.GetComponent<Light>().enabled = true;
            GetComponent<RocketMovement>().enabled = false;
            Invoke("ReloadLevel", levelLoadDelay);
        }
    }

    void LoadNextLevel()
    {
        TimeManager.SlowTime = false;
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;

/*        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }*/

        if (currentSceneIndex >= PlayerPrefs.GetInt("lvlsUnlocked"))
        {
            PlayerPrefs.SetInt("lvlsUnlocked", nextSceneIndex);
        }
        Debug.Log("lvl" + PlayerPrefs.GetInt("lvlsUnlocked") + " unlocked");

        SceneManager.LoadScene(nextSceneIndex);
        //SceneManager.LoadScene(currentSceneIndex + 1);
    }
    void ReloadLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
}


