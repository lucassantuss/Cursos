import styles from './PostModelo.module.css';

export default function PostModelo({ fotoCapa, titulo, children }) {
  return (
    <article className={styles.postModeloContainer}>
      <div className={styles.fotoCapa} style={{backgroundImage: `url(${fotoCapa})`}} />
      <h2 className={styles.titulo}>{titulo}</h2>
      <div className={styles.postContainer}>{children}</div>
    </article>
  )
}