using UnityEngine;

namespace Manager
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        // instance 선언 (싱글톤 인스턴스를 저장하는 변수)
        private static T instance;

        // instance 프로퍼티(읽기 가능, 외부 수정 불가)
        public static T Instance
        {
            get
            {
                // 만약 instance가 null일 경우 (싱글톤 인스턴스가 아직 없음)
                if (instance == null)
                {
                    // 현재 씬에서 T 타입인 오브젝트를 찾아 instance에 할당
                    instance = FindFirstObjectByType<T>();

                    // T와 동일한 타입인 Object를 못 찾은 경우
                    if (instance == null)
                    {
                        // 새로운 GameObject를 생성(이름은 클래스의 이름을 따름)
                        GameObject obj = new GameObject(typeof(T).Name);
                        // 그리고 instance는 GameObject에 추가하는 T 타입의 컴포넌트로 할당
                        instance = obj.AddComponent<T>();
                        // 그리고 씬이 바뀌더라도 삭제되지 않게 DonDestroyOnLoad를 호출
                        DontDestroyOnLoad(obj);
                    }
                }

                return instance;
            }
        }

        protected virtual void Awake()
        {
            // 현재 싱글톤 인스턴스가 null이라면 이 오브젝트를 싱글톤으로 설정
            if (instance == null)
            {
                instance = this as T;
                DontDestroyOnLoad(gameObject);
            }
            else if (instance != this)
            {
                // 만약 이미 존재하는 싱글톤 인스턴스가 있다면, 새로 생성된 이 중복 오브젝트는 삭제
                Destroy(gameObject);
            }
        }
    }
}

