# HRtest
> 정리
- 이동의 세가지 방법 : Transform, AddForce, Vector의 MovePosition
 > MovetoWard : Transform이 방향대로 쭉 이동하고 MovetoWard는 원하는 위치를 지정하여 이동한다.
 >> Vector3의 값을 가져오면 (GameObject.transform.position.x, GameObject.transform.position.y, GameObject.transform.position.z )로 구성됨
 새 백터 함수에 가져올 값만 넣어서 가져온다. - 공중부양 방지
- 반전 세가지 : Rotation, Animation, SpriteRenderer Flip
- 안개 : Particle System >> 회전 후 시간 크기 색상 변경
- 유니티 내에서 애니메이션 생성 시 Debug 탭에서 Legacy 체크, Normal 탭에서 Once로 변경
- 조명( 점등, Intensity 조절 ) : 파티클에 Texture Sheet Animation, Renderer, LifeTime 설정 >> 애니메이션, 스크립트 코루틴 사용
- 문 열기
1. 문 흰지 애니메이션 89도. 문에 애니메이터 제거 후 애니메이션 등록
2. InputManager 전체 크기 +1 이름과 상호작용 키 등록
3. Laycast 오브젝트 간 거리를 Static 변수에 담기
4. 문 트리거 오브젝트로 OnMouseOver, OnMouseExit 사용
- 오브젝트 설명 UI : OnMouseOver, Exit SetActive
- 페이드인 : UI > RawImage > 검정색 Alpha값 애니메이션 적용 > 스크립트에서 끄기 > 플레이어 이동 컴포넌트 Enabled 끄기 > 코루틴 시작 > 코루틴 종료 전까지 텍스트 진행
- 트리거 : 큐브 렌더러 끄고 콜라이더 트리거 ON > 스크립트 온 트리거 플레이어 컴포넌트 끄기 & 코루틴 텍스트 진행 >
- 아이템 획득 : 필드/실제 두가지 오브젝트를 두고 트리거 콜라이더에서 상호작용 시 SetActive ON/Off 동시 적용
- 점프스퀘어A : 트리거에 BGM, 오브젝트, 애니메이션 실행
- 원거리 공격 : Raycast로 SendMessage 사용. 받은 오브젝트에서 SendMessage의 값을 적용시킴
- 오브젝트 온/오프 체크 : gameObject.activeSelf == true
- OnCollision > Collision, OnTrigger > Collider, 충돌체크 Collision/Collider.GameObject == 비교 오브젝트
- 추노 : Vector3.MoveTowards(쫓아갈 대상, 쫓을 대상(Vector3(x, y, z), 속도) 
 > 플레이어 주변 콜라이더와 충돌 시 속도 0, 코루틴 사용
- 애니메이션 : animator.Play("name");, animator.CrossFade("name", 변한시간f);
- 피해 입음 : UI > RawImage 색, 알파값 변경 > 적 공격 코루틴 사이에 입력
- 총알 : UI 총알 갯수를 static으로 얻으면 늘고 쓰면 달게
- 안개 수치조정
- ReflectionProve : 반사광 적용 RealTime, Indensity, 필드 조명들 RendererMode Important 변경
- bgm : 좀비 죽기전과 죽은 후에 On/Off로 변경
- // 안함 렌더링 : ProjectSetting > QuallitySetting > disable, Camera > RenderingPath > Deferred, Camera > MSAA Off
- 포스트 프로세싱
Ambient Occlusion > Bloom > Color Grading > Grain > Vignette 적용. Bloom은 선택.
1. Ambient Occlusion : Multi Scale, Intensity, ThicknessModifier 설정
2. Bloom : Intensity, Diffusion, Color, Texture&Intensity 설정
3. Color Grading : Mode > HDR, Neutral // Temperature, Post-exposure(EV), Saturation, Contrast, Channel Mixer 설정
- Terrain
1. 설정 Mesh Resulution 설정
2. Raisy of Lower Terrain & brush로 지형 다듬기
3. Paint Texture & brush로 바닥 색칠
4. Paint Trees > Edit Trees > Add Trees > 브러시 크기, 빽빽함, 나무 크기 조절후 드래그로 깔기
5. Paint Details > Edit Details > 크기, 색상 설정 > 환경설정에서 낡은색상 설정 드래그로 깔기
6. PostProcessing 복사 > Color Grading > Saturation, Contrast -100, 100 으로 설정하여 흑백화면 만들고 Directional Light > Intensity 설정
- SceneManager ( 씬 전환 )
1.ImageLaw 흑백 > 알파값 0->255 FadeIn <=> 255->0 FadeOut
2.Couroutine 값 주고 SetActive true > SceneManager.LoadScene으로 변경
- Text ( 자막 ) : Text 오브젝트 스크립트에서 불러오고 .GetComponent<Text>().text = ""; & yield return WaitForSeconds(f);
- 아이템 : 파티클 크기 주기 설정 후 아이템에 넣기
- 날아가는 오브젝트 : 구, 상자 생성. 구에 트리거 코루틴.
- TextMeshPro ( 컴포넌트 )
>using UnityEngine.UI;
>using TMPro;

>void Update()
>{
>    TextMeshPro lemonsss = GetComponent<TextMeshPro>();
>}
>구성 요소 텍스트 메쉬 프로 가져 오기
>GetComponent<TMPro.TextMeshProUGUI>().text

-마우스 커서 숨기기 (Start()), 마우스 위치 고정
> Cursor.lockState = CursorLockMode.Locked; Cursor.visible = false;
> Cursor.lockState = CursorLockMode.None;
> + Cursor.lockState = CursorLockMode.Confined 화면밖으로 못나가게함.

- 부모, 자식 컴포넌트, 오브젝트 호출
> .transform.GetComponentInParent
> gameObject.transform.parent

- 로드 후에 사라지지 않게
> DontDestroyOnLoad()

- ?
1. 애니메이터 삭제 후 애니메이션 등록
2. Collision, Trigger 와 Laycast
3. namespace UnityStandardAssets.Characters.FirstPerson
