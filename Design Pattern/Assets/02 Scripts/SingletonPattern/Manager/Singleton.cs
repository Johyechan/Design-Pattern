using UnityEngine;

namespace Manager
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // instance ���� (�̱��� �ν��Ͻ��� �����ϴ� ����)
        private static T instance;

        // instance ������Ƽ(�б� ����, �ܺ� ���� �Ұ�)
        public static T Instance
        {
            get
            {
                // ���� instance�� null�� ��� (�̱��� �ν��Ͻ��� ���� ����)
                if (instance == null)
                {
                    // ���� ������ T Ÿ���� ������Ʈ�� ã�� instance�� �Ҵ�
                    instance = FindFirstObjectByType<T>();

                    // T�� ������ Ÿ���� Object�� �� ã�� ���
                    if (instance == null)
                    {
                        // ���ο� GameObject�� ����(�̸��� Ŭ������ �̸��� ����)
                        GameObject obj = new GameObject(typeof(T).Name);
                        // �׸��� instance�� GameObject�� �߰��ϴ� T Ÿ���� ������Ʈ�� �Ҵ�
                        instance = obj.AddComponent<T>();
                        // �׸��� ���� �ٲ���� �������� �ʰ� DonDestroyOnLoad�� ȣ��
                        DontDestroyOnLoad(obj);
                    }
                }

                return instance;
            }
        }

        protected virtual void Awake()
        {
            // ���� �̱��� �ν��Ͻ��� null�̶�� �� ������Ʈ�� �̱������� ����
            if (instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
            {
                // ���� �̹� �����ϴ� �̱��� �ν��Ͻ��� �ִٸ�, ���� ������ �� �ߺ� ������Ʈ�� ����
                Destroy(gameObject);
            }
        }
    }
}

