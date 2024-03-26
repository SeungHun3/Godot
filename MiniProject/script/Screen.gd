extends Node

var current_window_size = OS.get_window_size()

func _ready():
	# ScreenSizeChanged 이벤트를 연결합니다.
	get_tree().connect("screen_resized", self, "_on_screen_size_changed")

func _on_screen_size_changed():
	var new_window_size = OS.get_window_size()
	# 이전 창 크기와 현재 창 크기를 비교하여 해상도가 변경되었는지 확인합니다.
	if new_window_size != current_window_size:
		current_window_size = new_window_size
		# 해상도가 변경될 때 실행할 작업을 여기에 추가합니다.
		var new_width = new_window_size.x
		var new_height = new_window_size.y
		print("Screen resolution changed to: ", new_width, "x", new_height)
		# 여기에 다른 작업을 추가하세요.
