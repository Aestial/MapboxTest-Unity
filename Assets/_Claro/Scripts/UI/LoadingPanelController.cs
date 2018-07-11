namespace Claro
{
	using UnityEngine;
	using UnityEngine.UI;
    using UnityEngine.SceneManagement;

    public class LoadingPanelController : Singleton<LoadingPanelController>
	{
		[SerializeField]
		GameObject _content;

        [SerializeField]
        string _message;

		[SerializeField]
		Text _text;

		[SerializeField]
		AnimationCurve _curve;

        public void ActivePanel()
        {
            _content.SetActive(true);
        }

		void Awake()
		{
            _text.text = _message;
            SceneManager.sceneLoaded += OnSceneLoaded;
            _content.SetActive(false);
		}

        void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
            if (mode == LoadSceneMode.Additive)
                _content.SetActive(false);
		}

		void Update()
		{
			var t = _curve.Evaluate(Time.time);
			_text.color = Color.Lerp(Color.clear, Color.white, t);
		}
	}
}