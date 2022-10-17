import AES as aes

def print_separator_short():
    print("----------------------------------------------")


def print_separator_long():
    print(
        "=======================================================================================================================================")


if __name__ == '__main__':


    KEYS = ["Koluy Jnsdk Wrhs"]
    TEXTS = ["BayraktarTB2Glor"]
    for i in range(1):
        print_separator_long()
        main_key = aes.translate_string_into_hex_str(KEYS[i])
        main_text = aes.translate_string_into_hex_str(TEXTS[i])
        round_keys = aes.find_all_round_keys(main_key)
        encrypt_text = aes.encrypt(main_text, round_keys)
        encrypt_text_str = aes.translate_hex_into_str(encrypt_text)
        decrypt_text = aes.decryption(encrypt_text, round_keys)
        resolved_text = aes.translate_hex_into_str(decrypt_text)
        print("Key : \'{}\'".format(KEYS[i]))
        print("Message Text : \'{}\'".format(TEXTS[i]))
        print("Encrypted Text in HEX:", encrypt_text)
        print_separator_long()
