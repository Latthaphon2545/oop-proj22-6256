from random import randint
import functools

def intput_answer_user(msg):
    intput_number = float(input(msg))
    return intput_number

def E_game():
    print("E")
    e = [randint(1,10) for x in range(4)]
    return e
    
def M_game():
    print("M")
    m = [randint(10,100) for x in range(3)]
    return m

def H_game():
    print("H")
    h = [randint(100,1000) for x in range(2)]
    return h

def check_answer(input_user,answer):
    heart = 0
    if input_user == answer:
        print("ถูก")
    else:
        print("ผิด")
        heart += 1
    return heart

def show_number(lists):
    for i in lists:
        print(i,end=" ")

def ชั้น1_1():
        HEART_USER = 5
    # Easy ---------------------------------------------
        e_heart_user = HEART_USER
        while True:
            if e_heart_user != 0:
                print(f"มี {e_heart_user} ดวง")
                e = E_game()
                sum_e = sum(e)
                show_number(e)
                print(f"\n{sum_e}")
                intput = intput_answer_user("ชั้น 1 ด่าน 1: ")
                e_heart = check_answer(intput,sum_e)
                if e_heart == 0:
                    break
                e_heart_user -= e_heart
                print(f"เหลือ {e_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น1_2():
        HEART_USER = 5
    # Middle ---------------------------------------------
        m_heart_user = HEART_USER
        while True:
            if m_heart_user != 0:
                print(f"มี {m_heart_user} ดวง")
                m = M_game()
                sum_m = sum(m)
                show_number(m)
                print(f"\n{sum_m}")
                intput = intput_answer_user("ชั้น 1 ด่าน 2: ")
                m_heart = check_answer(intput,sum_m)
                if m_heart == 0:
                    break
                m_heart_user -= m_heart
                print(f"เหลือ {m_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()
        
def ชั้น1_3():
        HEART_USER = 5
    # Easy ---------------------------------------------
        h_heart_user = HEART_USER
        while True:
            if h_heart_user != 0:
                print(f"มี {h_heart_user} ดวง")
                h = H_game()
                sum_h = sum(h)
                show_number(h)
                print(f"\n{sum_h}")
                intput = intput_answer_user("ชั้น 1 ด่านบอส: ")
                h_heart = check_answer(intput,sum_h)
                if h_heart == 0:
                    break
                h_heart_user -= h_heart
                print(f"เหลือ {h_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()  

def ชั้น1():
    ชั้น1_1()
    print("=========================")
    ชั้น1_2()
    print("=========================")
    ชั้น1_3()

def ชั้น2_1():
        HEART_USER = 5
    # Easy ---------------------------------------------
        e_heart_user = HEART_USER
        while True:
            if e_heart_user != 0:
                print(f"มี {e_heart_user} ดวง")
                e = E_game()
                remove_e = functools.reduce(lambda x, y: x-y, e)
                show_number(e)
                print(f"\n{remove_e}")
                intput = intput_answer_user("ชั้น 2 ด่าน 1: ")
                e_heart = check_answer(intput,remove_e)
                if e_heart == 0:
                    break
                e_heart_user -= e_heart
                print(f"เหลือ {e_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น2_2():
        HEART_USER = 5
    # Easy ---------------------------------------------
        m_heart_user = HEART_USER
        while True:
            if m_heart_user != 0:
                print(f"มี {m_heart_user} ดวง")
                m = M_game()
                remove_m = functools.reduce(lambda x, y: x-y, m)
                show_number(m)
                print(f"\n{remove_m}")
                intput = intput_answer_user("ชั้น 2 ด่าน 2: ")
                m_heart = check_answer(intput,remove_m)
                if m_heart == 0:
                    break
                m_heart_user -= m_heart
                print(f"เหลือ {m_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น2_3():
        HEART_USER = 5
    # Easy ---------------------------------------------
        h_heart_user = HEART_USER
        while True:
            if h_heart_user != 0:
                print(f"มี {h_heart_user} ดวง")
                h = H_game()
                remove_h = functools.reduce(lambda x, y: x-y, h)
                show_number(h)
                print(f"\n{remove_h}")
                intput = intput_answer_user("ชั้น 2 ด่านบอส: ")
                h_heart = check_answer(intput,remove_h)
                if h_heart == 0:
                    break
                h_heart_user -= h_heart
                print(f"เหลือ {h_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น2():
    ชั้น2_1()
    print("=========================")
    ชั้น2_2()
    print("=========================")
    ชั้น2_3()

def E_mul_divi_game():
    print("E")
    e = [randint(1,10) for x in range(2)]
    return e

def M_mul_divi_game():
    print("M")
    m = [randint(1,10) for x in range(3)]
    return m

def H_mul_divi_game():
    print("H")
    h = [randint(1,10) for x in range(4)]
    return h
       
def ชั้น3_1():
        HEART_USER = 5
    # Easy ---------------------------------------------
        e_heart_user = HEART_USER
        while True:
            if e_heart_user != 0:
                print(f"มี {e_heart_user} ดวง")
                e = E_mul_divi_game()
                multiply_e = functools.reduce(lambda x, y: x*y, e)
                show_number(e)
                print(f"\n{multiply_e}")
                intput = intput_answer_user("ชั้น 3 ด่าน 1: ")
                e_heart = check_answer(intput,multiply_e)
                if e_heart == 0:
                    break
                e_heart_user -= e_heart
                print(f"เหลือ {e_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น3_2():
        HEART_USER = 5
    # mid ---------------------------------------------
        m_heart_user = HEART_USER
        while True:
            if m_heart_user != 0:
                print(f"มี {m_heart_user} ดวง")
                m = M_mul_divi_game()
                multiply_m = functools.reduce(lambda x, y: x*y, m)
                show_number(m)
                print(f"\n{multiply_m}")
                intput = intput_answer_user("ชั้น 3 ด่าน 2: ")
                m_heart = check_answer(intput,multiply_m)
                if m_heart == 0:
                    break
                m_heart_user -= m_heart
                print(f"เหลือ {m_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น3_3():
        HEART_USER = 5
    # h ---------------------------------------------
        h_heart_user = HEART_USER
        while True:
            if h_heart_user != 0:
                print(f"มี {h_heart_user} ดวง")
                h = H_mul_divi_game()
                multiply_m = functools.reduce(lambda x, y: x*y, h)
                show_number(h)
                print(f"\n{multiply_m}")
                intput = intput_answer_user("ชั้น 3 ด่านบอส: ")
                h_heart = check_answer(intput,multiply_m)
                if h_heart == 0:
                    break
                h_heart_user -= h_heart
                print(f"เหลือ {h_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น3():
    ชั้น3_1()
    print("=========================")
    ชั้น3_2()
    print("=========================")
    ชั้น3_3()

def ชั้น4_1():
        HEART_USER = 5
    # Easy ---------------------------------------------
        e_heart_user = HEART_USER
        while True:
            if e_heart_user != 0:
                print(f"มี {e_heart_user} ดวง")
                e = E_mul_divi_game()
                multiply_e = functools.reduce(lambda x, y: x//y, e)
                show_number(e)
                print(f"\n{multiply_e}")
                intput = intput_answer_user("ชั้น 4 ด่าน 1: ")
                e_heart = check_answer(intput,multiply_e)
                if e_heart == 0:
                    break
                e_heart_user -= e_heart
                print(f"เหลือ {e_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น4_2():
        HEART_USER = 5
    # mid ---------------------------------------------
        m_heart_user = HEART_USER
        while True:
            if m_heart_user != 0:
                print(f"มี {m_heart_user} ดวง")
                m = M_mul_divi_game()
                multiply_m = functools.reduce(lambda x, y: x//y, m)
                show_number(m)
                print(f"\n{multiply_m}")
                intput = intput_answer_user("ชั้น 4 ด่าน 2: ")
                m_heart = check_answer(intput,multiply_m)
                if m_heart == 0:
                    break
                m_heart_user -= m_heart
                print(f"เหลือ {m_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น4_3():
        HEART_USER = 5
    # h ---------------------------------------------
        h_heart_user = HEART_USER
        while True:
            if h_heart_user != 0:
                print(f"มี {h_heart_user} ดวง")
                h = H_mul_divi_game()
                multiply_m = functools.reduce(lambda x, y: x//y, h)
                show_number(h)
                print(f"\n{multiply_m}")
                intput = intput_answer_user("ชั้น 4 ด่านบอส: ")
                h_heart = check_answer(intput,multiply_m)
                if h_heart == 0:
                    break
                h_heart_user -= h_heart
                print(f"เหลือ {h_heart_user} ดวง")
                print("-" *20)
            else:
                print("เริ่มใหม่")
                exit()

def ชั้น4():
    ชั้น4_1()
    print("=========================")
    ชั้น4_2()
    print("=========================")
    ชั้น4_3()

if __name__ == "__main__":
    ชั้น1()
    print("-*" *100)
    ชั้น2()
    print("-*" *100)
    ชั้น3()
    print("-*" *100)
    ชั้น4()