import styles from './Banner.module.css'
import circuloColorido from 'assets/circulo_colorido.png'
import minhaFoto from 'assets/minha_foto.png'

export default function Banner() {
    return (
        <div className={styles.banner}>
            <div className={styles.apresentacao}>
                <h1 className={styles.titulo}>
                    Olá, Mundo!
                </h1>
                <p className={styles.paragrafo}>
                    Boas vindas à minha página! Eu sou o Lucas Araujo, desenvolvedor Full-Stack.
                </p>
            </div>

            <div className={styles.imagens}>
                <img 
                    className={styles.circuloColorido}
                    src={circuloColorido}
                    aria-hidden={true}
                    alt="Circulo colorido"
                />
                <img 
                    className={styles.minhaFoto}
                    src={minhaFoto}
                    alt="Foto do Lucas Araujo"
                />
            </div>
        </div>
    )
}